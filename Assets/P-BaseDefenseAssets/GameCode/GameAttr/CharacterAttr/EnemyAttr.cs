using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemys数值
public class EnemyAttr : ICharacterAttr
{
    protected int m_CriRate = 0; //爆击机率
    public EnemyAttr()
    {

    }
    //设定角色数值(包含外部参数)
    public void SetEnemyAttr(EnemyBaseAttr EnemyBaseAttr)
    {
        //共用元件
        base.SetBaseAttr(EnemyBaseAttr);

        //外部参数
        m_CriRate = EnemyBaseAttr.GetInitCriRate();
    }
    //暴击率
    public int GetCriRate()
    {
        return m_CriRate;
    }
    //减少暴击率
    public void CutdownCritRate()
    {
        m_CriRate -= m_CriRate / 2;
    }
}
