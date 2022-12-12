using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//攻击状态
public class AttackAIState : IAIState
{
    private ICharacter m_AttakcTarget = null;//攻击的目标
    public AttackAIState(ICharacter AttackTarget)
    {
        m_AttakcTarget = AttackTarget;
    }
    //更新
    public override void Update(List<ICharacter> Targets)
    {
        //没有目标是，改为idel
        if (m_AttakcTarget == null||m_AttakcTarget.IsKilled()||Targets==null||Targets.Count==0)
        {
            m_CharacterAI.ChangeAIState(new IdleAIState());
            return;
        }
        //不在攻击目标内,改为追击
        if (m_CharacterAI.TargetInAttackRange(m_AttakcTarget) == false)
        {
            m_CharacterAI.ChangeAIState(new ChaseAIState(m_AttakcTarget));
            return;
        }

        //攻击
        m_CharacterAI.Attack(m_AttakcTarget);
    }
    //目标被移除
    public override void RemoveTarget(ICharacter Target)
    {
        if (m_AttakcTarget.GetGameObject().name == Target.GetGameObject().name)
            m_AttakcTarget = null;
    }
}
