using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneStateController 
{
    private ISceneState m_State;
    private bool m_bRunBegin = false;
    AsyncOperation async;
    public SceneStateController() { }
    public void SetState(ISceneState State,string LoadSceneName)
    {
        m_bRunBegin = false;

        //载入场景
        LoadScene(LoadSceneName);
        if (m_State != null)
        {
            m_State.StateEnd();
        }
        //设定
        m_State = State;
    }
    //载入场景
    private void LoadScene(string LoadSceneName)
    {
        if (LoadSceneName == null || LoadSceneName.Length == 0)
            return;
        //Application.LoadLevel(LoadSceneName);
        async = SceneManager.LoadSceneAsync(LoadSceneName);
    }
    //更新
    public void StateUpdate()
    {
        //是否还在载入
        if(async != null &&  !async.isDone)
        {
            return;
        }
        //if (Application.isLoadingLevel)
        //{
        //    return;
        //}

        //通知新的state开始
        if (m_State != null && m_bRunBegin == false)
        {
            m_State.StateBegin();
            m_bRunBegin = true;
        }
        if (m_State != null)
        {
            m_State.StateUpdate();
        }
    }
}
