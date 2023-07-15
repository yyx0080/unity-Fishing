using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//���س���ʱ������


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
    //�˳���Ϸ
    public void QuitGame()
    {
        Application.Quit();//�˳�Ӧ��
    }
    //��ʼ��Ϸ
    public void BeginTheGame()
    {
        SceneManager.LoadScene("GamePlay");//GamePlayΪ����Ҫ�л����ĳ���
    }

    //�������˵�
    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ReFishingWin()
    {
        //���¿�ʼ���㣬Ҫ�ѵ���ϵͳ��������Ϊfalse
        //���ý�����
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
    //�رոý���
    public void CloseCurUI()
    {
        this.gameObject.SetActive(false);
    }
    //���̵�
    public void OpenShop()
    {
        shop.SetActive(true);
    }
    //�ر��̵�
    public void CloseShop()
    {
        shop.SetActive(false);
    }
    //�򿪱���
    public void OpenBag()
    {
        bag.SetActive(true);
    }
    //�رձ���
    public void CloseBag()
    {
        bag.SetActive(false);
    }
    //��˵��
    public void OpenInformation()
    {
        SceneManager.LoadScene("information");
    }
}
