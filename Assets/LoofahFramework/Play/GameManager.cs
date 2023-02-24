using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 游戏全局管理器
/// </summary>
public class GameManager : MonoSingleton<GameManager>
{
    public bool DebugMode;
    private Camera mainCamera;
    public Camera MainCamera => mainCamera;
    protected override void Awake()
    {
        base.Awake();
        RegisterCamera();
    }
    #region 事件
    private void OnEnable()
    {
        EventMgr.GetInstance().AddEventListener(EventDic.AfterChangeScene, RegisterCamera);
    }
    private void OnDisable()
    {
        EventMgr.GetInstance().DeleteEventListener(EventDic.AfterChangeScene, RegisterCamera);
    }
    private void RegisterCamera()
    {
        mainCamera = Camera.main;
    }
    #endregion
}
