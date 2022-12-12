using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSergeant : ISoldier
{
    public SoldierSergeant()
    {
        m_emSoldier = ENUM_Soldier.Sergeant;
        m_AssetName = "Soldier2";
        m_IconSpriteName = "SergeantIcon";
        m_AttrID = 2;
    }
    //播放音效
    public override void DoPlayKilledSound()
    {
        PlaySound("SergeantDeath");
    }
    //播放特效
    public override void DoShowKilledEffect()
    {
        PlayEffect("SergeantDeadEffect");
    }
    //执行Vieitor
    public override void RunVisitor(ICharacterVisitor Visitor)
    {
        Visitor.VisitSoldierSergeant(this);
    }
}
