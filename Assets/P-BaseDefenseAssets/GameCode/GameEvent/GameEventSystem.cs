using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ENUM_GameEvent
{
    Null =0,
    EnemyKilled =1,//地方单位阵亡
    SoldierKilled =2,//玩家单位阵亡
    SoldierUpgate = 3,//玩家单位升级
    NewStage = 4,//新关卡
}
public class GameEventSystem : IGameSystem
{
    private Dictionary<ENUM_GameEvent, IGameEventSubject> m_GameEvents = new Dictionary<ENUM_GameEvent, IGameEventSubject>();
    public GameEventSystem(PBaseDefenseGame PBDGame):base(PBDGame)
    {
        Initialize();
    }
    public override void Release()
    {
        m_GameEvents.Clear();
    }
    public void RegisterObserver(ENUM_GameEvent emGameEvnet,IGameEventObserver Observer)
    {
        //IGameEventSubject Subject = 
    }
    //private IGameEventSubject GetGameEventSubject(ENUM_GameEvent enGameEvent)
    //{
    //    if (m_GameEvents.ContainsKey(enGameEvent))
    //        return m_GameEvents[enGameEvent];
    //    IGameEventSubject pSujbect = null;
    //    switch (enGameEvent)
    //    {
    //        case ENUM_GameEvent.Null:
    //            //pSujbect = new E
    //            break;
    //        case ENUM_GameEvent.EnemyKilled:
    //            break;
    //        case ENUM_GameEvent.SoldierKilled:
    //            break;
    //        case ENUM_GameEvent.SoldierUpgate:
    //            break;
    //        case ENUM_GameEvent.NewStage:
    //            break;
    //        default:
    //            break;
    //    }
    //}
}
