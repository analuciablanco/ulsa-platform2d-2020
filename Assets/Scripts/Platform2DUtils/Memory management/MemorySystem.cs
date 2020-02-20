using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Platform2DUtils.MemorySystem
{
    public class MemorySystem 
    {
        public static void SaveData(GameData gameData)
        {
            string path = $"{Application.persistentDataPath}/myGame.data";
            
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(path);
            
            string json = JsonUtility.ToJson(gameData);
            bf.Serialize(file, json);
            file.Close();
            Debug.Log(path);
        }

        public static GameData LoadData()
        {
            string path = $"{Application.persistentDataPath}/myGame.data";

            if(File.Exists(path))
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                FileStream file = File.Open(path, FileMode.Open);

                string json = binFormatter.Deserialize(file) as string;
                GameData gameData = JsonUtility.FromJson<GameData>(json);

                return gameData;
            }

            return new GameData();
        }
    }
}