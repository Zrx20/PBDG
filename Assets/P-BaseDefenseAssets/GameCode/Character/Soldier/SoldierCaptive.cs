using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCaptive : ISoldier
{
    private IEnemy m_Captive = null;
    public SoldierCaptive(IEnemy theEnemy)
    {
        m_emSoldier = ENUM_Soldier.Captive;
        m_Captive = theEnemy;

        //设定成像
        SetGameObject(theEnemy.GetGameObject());

        //将Enemy数值转成Soldier用的
        SoldierAttr tempAttr = new SoldierAttr();
        tempAttr.SetSoldierAttr(theEnemy.GetCharacterAttr().GetBaseAttr());
        tempAttr.SetAttStrategy(theEnemy.GetCharacterAttr().GetAttStrategy());
        tempAttr.SetSoldierLv(1);//设定为1级
        SetCharacterAttr(tempAttr);

        //设定武器
        SetWeapon(theEnemy.GetWeapon());

        //更改为SoldierAI
        //m_AI = new SoldierAI(this);
    }
    public override void DoPlayKilledSound()
    {
        throw new System.NotImplementedException();
    }

    public override void DoShowKilledEffect()
    {
        throw new System.NotImplementedException();
    }
}
