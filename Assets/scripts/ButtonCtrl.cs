using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //退出游戏
    public void QuitGame()
    {
        Application.Quit();//退出应用
    }
    //开始游戏
    public void BeginTheGame()
    {
        SceneManager.LoadScene("GamePlay");//GamePlay为我们要切换到的场景
    }
    //返回主菜单
    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
