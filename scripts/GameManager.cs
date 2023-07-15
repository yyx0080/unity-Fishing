using System.Collections;
using UnityEngine;


/// <summary>
/// 游戏管理器
/// </summary>
[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    #region 变量

    public static GameManager Instance { get; private set; }

    #endregion

    #region Mono

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    #endregion

    #region private



    #endregion

}