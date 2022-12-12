using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewStageSubject : IGameEventSubject
{
    private int m_StageCount = 1;
    public NewStageSubject() { }
    //目前关卡数
    public int GetStageCount()
    {
        return m_StageCount;
    }
    //通知
    public override void SetParam(object Param)
    {
        base.SetParam(Param);
        m_StageCount = (int)Param;

        //通知
        Notify();
    }
}
