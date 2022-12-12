using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//可以被共用的基本角色数值界面
public abstract class BaseAttr 
{
    public abstract int GetMaxHP();
    public abstract float GetMoveSpeed();
    public abstract string GetAttrName();
}
public class CharacterBaseAttr : BaseAttr
{
    private int m_MaxHP; //最高HP值
    private float m_MoveSpeed; //目前移动速度
    private string m_AttrName; //数值的名称
    public CharacterBaseAttr(int MaxHP,float MoveSpeed,string AttrName)
    {
        m_MaxHP = MaxHP;
        m_MoveSpeed = MoveSpeed;
        m_AttrName = AttrName;
    }

    public override string GetAttrName()
    {
        return m_AttrName;
    }

    public override int GetMaxHP()
    {
        return m_MaxHP;
    }

    public override float GetMoveSpeed()
    {
        return m_MoveSpeed;
    }
}
//敌方角色的基本数值
public class EnemyBaseAttr : CharacterBaseAttr
{
    public int m_InitCriRate;
    public EnemyBaseAttr(int MaxHP,float MoveSpeed,string AttrName,int CritRate):base(MaxHP,MoveSpeed,AttrName)
    {
        m_InitCriRate = CritRate;
    }
    public virtual int GetInitCriRate()
    {
        return m_InitCriRate;
    }
}
