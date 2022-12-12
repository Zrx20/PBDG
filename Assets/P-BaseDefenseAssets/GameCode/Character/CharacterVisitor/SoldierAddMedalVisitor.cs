using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//增加Solder勋章
public class SoldierAddMedalVisitor : ICharacterVisitor
{
    PBaseDefenseGame m_PBDGame = null;
    public SoldierAddMedalVisitor(PBaseDefenseGame PBDGame)
    {
        m_PBDGame = PBDGame;
    }
    public override void VisitSoldier(ISoldier Soldier)
    {
        base.VisitSoldier(Soldier);
        //Soldier.a
    }
}
