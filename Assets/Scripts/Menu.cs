using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform2DUtils.MemorySystem;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] Button btnNewGame;
    [SerializeField] Button btnLoadGame;
    [SerializeField] Button btnQuitGame;



    private void Awake() 
    {
        btnNewGame.onClick.AddListener(NewGame);
        btnLoadGame.onClick.AddListener(LoadGame);
        btnQuitGame.onClick.AddListener(QuitGame);
    }

    private void Start() 
    {
        btnLoadGame.gameObject.SetActive(MemorySystem.DataExist);    
    }

    public void NewGame()
    {
        Debug.Log("New game");

        Gamemanager.instance.gameData = new GameData();
        MemorySystem.SaveData(Gamemanager.instance.gameData);
        SceneManager.LoadScene(1);
        btnLoadGame.gameObject.SetActive(false);
        Gamemanager.instance.Score.gameObject.SetActive(true);
    }

    public void LoadGame()
    {
        Debug.Log("Load game");
    }

    public void QuitGame()
    {
        Debug.Log("Quit game");
    }
}
