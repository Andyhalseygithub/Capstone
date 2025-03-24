using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Mainmenu : MonoBehaviour
{
    public static Mainmenu instance;
    public GameObject quickplay;//, levelselect;
    private void Awake()
    {
        instance = this;
    }
    /*public void swapmenu()
    {
        ShowGameover1();
        gameObject.SetActive(true);
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
    */
    public void Quickplay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    /*
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
    }

    public void next2()
    {
        {
            SceneManager.LoadScene("Level 2");
        }
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("Start");
    }
    */
}
