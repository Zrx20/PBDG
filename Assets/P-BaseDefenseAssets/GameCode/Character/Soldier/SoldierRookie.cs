using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//新兵
public class SoldierRookie : ISoldier
{
    public SoldierRookie()
    {
        m_emSoldier = ENUM_Soldier.Rookie;
        m_AssetName = "Soldier1";
        m_IconSpriteName = "RookieIcon";
        m_AttrID = 1;
    }
    //播放音效

    public override void DoPlayKilledSound()
    {
        
    }

    public override void DoShowKilledEffect()
    {
        throw new System.NotImplementedException();
    }
}
