using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//建立Soldier时所需的参数
public class SoldierBuildParam:ICharacterBuildParam
{
    public int Lv = 0;
    public SoldierBuildParam()
    {

    }
}
public class SoldierBuilder : ICharacterBuilder
{
    private SoldierBuildParam m_BuildParam = null;
    public override void AddAi()
    {
        SoldierAI theAI = new SoldierAI(m_BuildParam.NewCharacter);
        m_BuildParam.NewCharacter.SetAI(theAI);
    }

    public override void AddCharacterSystem(PBaseDefenseGame PBDGame)
    {
        //PBDGame.
    }

    public override void AddOnClickScript()
    {
        throw new System.NotImplementedException();
    }

    public override void AddWeapon()
    {
        throw new System.NotImplementedException();
    }

    public override void LoadAsset(int GameObjectID)
    {
        throw new System.NotImplementedException();
    }

    public override void SetBuildParam(ICharacterBuildParam theParam)
    {
        throw new System.NotImplementedException();
    }

    public override void SetCharacterAttr()
    {
        throw new System.NotImplementedException();
    }
}
