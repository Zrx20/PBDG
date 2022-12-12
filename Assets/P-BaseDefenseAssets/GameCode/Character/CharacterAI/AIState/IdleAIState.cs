using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAIState : IAIState
{
    bool m_bSetAttackPosition = false;//是否有设定攻击目标
    public IdleAIState() { }
    //设定要攻击的目标
    public override void SetAttackPosition(Vector3 AttackPosition)
    {
        m_bSetAttackPosition = true;
    }
    public override void Update(List<ICharacter> Targets)
    {
        if (Targets == null || Targets.Count == 0)
        {
            if (m_bSetAttackPosition)
                m_CharacterAI.ChangeAIState(new MoveAIState());
            return;
        }

        //找出最近的目标
        Vector3 NowPosition = m_CharacterAI.GetPosition();
        ICharacter therNearTarget = null;
        float MinDist = 999f;
        foreach (ICharacter Target in Targets)
        {
            //已经阵亡的不计算
            if (Target.IsKilled())
                continue;

            float dist = Vector3.Distance(NowPosition, Target.GetGameObject().transform.position);
            if (dist<MinDist)
            {
                MinDist = dist;
                therNearTarget = Target;
            }
        }
        //没有目标,会不动
        if (therNearTarget == null)
            return;
        //是否在距离内
        if (m_CharacterAI.TargetInAttackRange(therNearTarget))
            m_CharacterAI.ChangeAIState(new AttackAIState(therNearTarget));
        else
            m_CharacterAI.ChangeAIState(new ChaseAIState(therNearTarget));
    }
}
