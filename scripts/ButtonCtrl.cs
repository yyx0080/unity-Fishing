using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//加载场景时需引用


public class ButtonCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject finshingSystem;
    public GameObject fail;
    public GameObject suc;
    public GameObject shop;
    public GameObject bag;
   
    public Slider slider;
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
    public void ReFishingWin()
    {
        //重新开始钓鱼，要把钓鱼系统重新设置为false
        //重置进度条
        finshingSystem.SetActive(false);
        slider.value = 0.5f;
        suc.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReFishingFail()
    {
        finshingSystem.SetActive(false);
        slider.value = 0.5f;
        fail.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //关闭该界面
    public void CloseCurUI()
    {
        this.gameObject.SetActive(false);
    }
    //打开商店
    public void OpenShop()
    {
        shop.SetActive(true);
    }
    //关闭商店
    public void CloseShop()
    {
        shop.SetActive(false);
    }
    //打开背包
    public void OpenBag()
    {
        bag.SetActive(true);
    }
    //关闭背包
    public void CloseBag()
    {
        bag.SetActive(false);
    }
    //打开说明
    public void OpenInformation()
    {
        SceneManager.LoadScene("information");
    }
}
