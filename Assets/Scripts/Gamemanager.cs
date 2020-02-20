using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Platform2DUtils.MemorySystem;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    [SerializeField] Score score;

    public GameData gameData{ get; set; }

    public Score Score { get => score; }

    private void Awake() 
    {
        if (instance)
       {
           Destroy(gameObject);
       }
       else
       {
           instance = this;
           gameData = new GameData();
       }
       DontDestroyOnLoad(gameObject);   
    }

    public void Save()
    {
        MemorySystem.SaveData(gameData);
    }

    private void Start() 
    {
        //int scene = SceneManager.GetActiveScene().buildIndex;
        //score.gameObject.SetActive(scene > 0);
    }
}
