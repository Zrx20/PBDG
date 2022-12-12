﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//产生游戏用数值界面
public abstract class IAttrFactory 
{
    //取得Soldier的数值
    public abstract SoldierAttr GetSoldierAttr(int AttrID);
    //取得Soldier的数值：有字首字尾的加成
    public abstract SoldierAttr GetEliteSoldierAttr(ENUM_AttrDecorator emType, int AttrID, SoldierAttr theSoldierAttr);
    //取得Enemy
    public abstract EnemyAttr GetEnemyAttr(int AttrID);
    //取得武器的数值
    public abstract WeaponAttr GetWeaponAttr(int AttID);
    //取得加乘用的数值
    public abstract AdditionalAttr GetAdditionlAtt(int AttrID);
}
