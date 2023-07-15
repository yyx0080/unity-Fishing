using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class FishingCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fish;//��
    public FishType[] fishType = new FishType[3];
    public int fish_select;//
    public GameObject PointA;//���Ͻ�
    public GameObject PointB;//���½�
    private Vector3 targetPosition;//λ�ü�¼
    public GameObject panel;
    public Image FishImage1;
    public Image FishImage2;
    public Image FishImage3;
    public struct FishType//�������
    {
        //ϡ�ж�
        public string name;//�������
        public float v;//�ٶ�
        public int gold_coin;//��Ľ�Ҽ�ֵ
    };
    void Start()
    {
        fishType[0].name = "Fish_1";
        fishType[0].v = 100.0f;
        fishType[1].name = "Fish_2";
        fishType[1].v = 200.0f;
        fishType[2].name = "Fish_3";
        fishType[2].v = 300.0f;
        fish_select = Random.Range(0, 3);
        targetPosition = GetRandomPositionInBounds();
        //����Ҫѡ�����ͼƬ
        SelectFishImage(fish_select);
        
    }
    
    // Update is called once per frame
    void Update()
    {
        MoveFish();
    }
    //������ƶ�������Ҫ���ǲ�ͬ������㣬���Ų�ͬ���������
    
    void MoveFish()
    {
        //�������������ڵ�����������ƶ�
        transform.position = Vector3.MoveTowards(transform.position, 
            targetPosition, fishType[fish_select].v*Time.deltaTime);
        //����ﵽĿ��㣬�ͻ���Ŀ���
        //Ϊ�˱��⿨ס��Ҫ�ƶ�һ����Χ
        if (Mathf.Abs(transform.position.x - targetPosition.x) <= 5.0 &&
            Mathf.Abs(transform.position.y - targetPosition.y) <= 5.0)
        {
            targetPosition = GetRandomPositionInBounds();
        }
        //�������Ҫ����
        //Debug.Log("fish_pos = " + transform.position);
        //Debug.Log("pos = " + targetPosition);


    }
    //����ƶ����꺯��
    private Vector3 GetRandomPositionInBounds()
    {
        float x = Random.Range(PointB.transform.position.x, PointA.transform.position.x);
        float y = Random.Range(PointB.transform.position.y, PointA.transform.position.y);
        return new Vector3(x, y, transform.position.z);
    }
    void SelectFishImage(int select)
    {
        fish.SetActive(true);
        if (select == 0)
        {
            FishImage1.color = new Vector4(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);//����
        }
        if(select == 1)
        {
            FishImage2.color = new Vector4(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);//����
        }
        if(select == 2)
        {
            FishImage3.color = new Vector4(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);//����
        }
    }

}
