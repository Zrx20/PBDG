using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBaseDefenseGame 
{
    private static PBaseDefenseGame _instance;
    public static PBaseDefenseGame Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PBaseDefenseGame();
            }
            return _instance;
        }
    }
    //游戏系统
    private GameEventSystem m_GameEventSystem = null;//游戏时间系统
    private bool m_bGameOver = false;
    private PBaseDefenseGame() { }
    //注册游戏事件
    public void RegisterGameEvent(ENUM_GameEvent emGameEvent,IGameEventObserver Observer)
    {
        m_GameEventSystem.RegisterObserver(emGameEvent, Observer);
    }
    public void Initinal()
    {

    }
    public void Update()
    {

    }
    public void Release()
    {

    }
    //增加Soldier
    public void AddSoldier(ISoldier theSoldier)
    {
        
    }
    public bool ThisGameIsOver()
    {
        return m_bGameOver;
    }
}
