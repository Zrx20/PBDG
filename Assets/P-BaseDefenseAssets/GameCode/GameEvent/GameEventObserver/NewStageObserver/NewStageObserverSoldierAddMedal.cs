﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//订阅新关卡—增加Solder勋章
public class NewStageObserverSoldierAddMedal : IGameEventObserver
{
    private NewStageSubject m_Subject = null;
    private PBaseDefenseGame m_PBDGame = null;
    public NewStageObserverSoldierAddMedal(PBaseDefenseGame PBDGame)
    {
        m_PBDGame = PBDGame;
    }
    public override void SetSubject(IGameEventSubject Subject)
    {
        m_Subject = Subject as NewStageSubject;
    }
    //通知Subject被更新
    public override void Update()
    {
        //增加勋章
       
    }
}
