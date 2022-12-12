using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//角色数值计算界面
public abstract class IAttrStrategy 
{
    //初始的数值
    public abstract void InitAttr(ICharacterAttr CharacterAttr);
    //攻击加成
    public abstract int GetAtkPlusValue(ICharacterAttr CharacterAttr);
    //取得减伤害值
    public abstract int GetDmgDescValue(ICharacterAttr CharacterAttr);
}
