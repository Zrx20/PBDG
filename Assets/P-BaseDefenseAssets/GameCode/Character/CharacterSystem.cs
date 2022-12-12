using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSystem : IGameSystem
{
    private List<ICharacter> m_Soldiers = new List<ICharacter>();
    private List<ICharacter> m_Enemys = new List<ICharacter>();
    public CharacterSystem(PBaseDefenseGame PBDGame):base(PBDGame)
    {
        Initialize();
        //注册事件
        //m_PBDGame.RegisterGameEvent(ENUM_GameEvent.NewStage)
    }
}
