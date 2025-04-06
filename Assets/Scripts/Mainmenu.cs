using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Mainmenu : MonoBehaviour
{
    public static Mainmenu instance;
    public GameObject main_menu, level_select;
    private void Awake()
    {
        instance = this;
    }

    public void Hide()
    {
        //gameObject.gameObject.SetActive(false);
        main_menu.SetActive(false);
        level_select.SetActive(false);
        // start time
        Time.timeScale = 1f;
    }

    void Start()
    {
        Hide();
        ShowMain();
    }

    void switchMenu(GameObject someMenu)
    {
        main_menu.SetActive(false);
        level_select.SetActive(false);

        someMenu.SetActive(true);
    }
    
    public void ShowMain()
    {
        switchMenu(main_menu);
    }
    public void ShowLevels()
    {
        switchMenu(level_select);
    }
    public void Quickplay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void LoadLevel1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }
}
