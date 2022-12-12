﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//建立角色时所需的参数
public abstract class ICharacterBuildParam
{
    public ENUM_Weapon enWeapon = ENUM_Weapon.Null;
    public ICharacter NewCharacter = null;
    public Vector3 SpawnPosition;
    public int AttrID;
    public string AssetName;
    public string IconSpriteName;
}
//介面用来生成ICharacter的各零件
public abstract class ICharacterBuilder 
{
    //设定建立参数
    public abstract void SetBuildParam(ICharacterBuildParam theParam);
    //载入Asset中的角色模型
    public abstract void LoadAsset(int GameObjectID);
    //加入OnClickScript
    public abstract void AddOnClickScript();
    //加入武器
    public abstract void AddWeapon();
    //加入AI
    public abstract void AddAi();
    //设定角色能力
    public abstract void SetCharacterAttr();
    //加入管理器
    public abstract void AddCharacterSystem(PBaseDefenseGame PBDGame);
}
