using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameoverMenucontroller : MonoBehaviour
{
    public static GameoverMenucontroller instance;
    public GameObject gameover1, gameover2;

    //methods
    private void Awake()
    {
        instance = this;
    }
    public void Gameover1()
    {
        ShowGameover1();
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Gameover2()
    {
        ShowGameover2();
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Hide()
    {
        //gameObject.gameObject.SetActive(false);
        gameover1.SetActive(false);
        gameover2.SetActive(false);
        // start time
        Time.timeScale = 1f;
    }
 
    void Start()
    {
        Hide(); 
    }
    void switchMenu(GameObject someMenu)
    {
        gameover1.SetActive(false);
        gameover2.SetActive(false);
        
        someMenu.SetActive(true);
    }

    public void ShowGameover1() 
    {
        switchMenu(gameover1);
    }
    public void ShowGameover2()
    {
        switchMenu(gameover2);
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("Start");
    }
}