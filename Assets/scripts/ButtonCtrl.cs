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
}
