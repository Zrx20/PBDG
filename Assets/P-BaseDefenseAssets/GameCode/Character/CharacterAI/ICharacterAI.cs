﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacterAI 
{
    protected ICharacter m_Character = null;
    protected float m_AttackRange = 2;
    protected IAIState m_AIstate = null;

    protected const float ATTACK_COOLD_DOWN = 1f;//攻击的CoolDown
    protected float m_CoolDown = ATTACK_COOLD_DOWN;

    public ICharacterAI(ICharacter Character)
    {
        m_Character = Character;
        m_AttackRange = Character.GetAttackRange();
    }
    //更换AI状态
    public virtual void ChangeAIState(IAIState NewAIState)
    {
        m_AIstate = NewAIState;
        m_AIstate.SetCharacterAI(this);
    }
    //攻击目标
    public virtual void Attack(ICharacter Target)
    {
        //时间到了才攻击
        m_CoolDown -= Time.deltaTime;
        if (m_CoolDown > 0)
            return;
        m_CoolDown = ATTACK_COOLD_DOWN;

        //m_Character.att
    }
    //是否在攻击距离内
    public bool TargetInAttackRange(ICharacter Target)
    {
        float dist = Vector3.Distance(m_Character.GetPosition(), Target.GetPosition());
        return (dist <= m_AttackRange);
    }
    //目前的位置
    public Vector3 GetPosition()
    {
        return m_Character.GetGameObject().transform.position;
    }
    //移动
    public void MoveTo(Vector3 Position)
    {
        m_Character.MoveTo(Position);
    }
    //停止移动
    public void StopMove()
    {
        m_Character.StopMove();
    }
    //设定阵亡
    public void Killed()
    {
        m_Character.Killed();
    }
    public bool IsKilled()
    {
        return m_Character.IsKilled();
    }
    //目标移除
    public void RemoveAITarget(ICharacter Target)
    {
        m_AIstate.RemoveTarget(Target);
    }
    //更新AI
    public void Update(List<ICharacter> Targets)
    {
        m_AIstate.Update(Targets);
    }
    //是否可以攻击Heart
    public abstract bool CanAttackHeart();
}
