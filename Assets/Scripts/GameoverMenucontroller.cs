using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameoverMenucontroller : MonoBehaviour
{
    public static GameoverMenucontroller instance;
    public GameObject gameover1, gameover2, gamewon;
    public bool check;
    public float level;

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
        check = true;
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Gamewon()
    {
        ShowGamewon();
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Hide()
    {
        //gameObject.gameObject.SetActive(false);
        gameover1.SetActive(false);
        gameover2.SetActive(false);
        gamewon.SetActive(false);
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
        gamewon.SetActive(false);


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
    public void ShowGamewon()
    {
        switchMenu(gamewon);
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void restart()
    {
        if (level == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (level == 2)
        {
            SceneManager.LoadScene("Level 2");
        }
        if (level == 3)
        {
            SceneManager.LoadScene("Level 3");
        }
        if (level == 4)
        {
            SceneManager.LoadScene("Level 4");
        }
    }

    public void next2()
    {
        {
            SceneManager.LoadScene("Level 2");
        }
    }
    public void next3()
    {
        {
            SceneManager.LoadScene("Level 3");
        }
    }
    public void next4()
    {
        {
            SceneManager.LoadScene("Level 4");
        }
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("Start");
    }
}