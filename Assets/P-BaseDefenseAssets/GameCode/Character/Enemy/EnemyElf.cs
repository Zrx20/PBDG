﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//精灵
public class EnemyElf : IEnemy
{
    public EnemyElf()
    {
        m_emEnemyType = ENUM_Enemy.Elf;
        m_AssetName = "Enemy1";
        m_AttrID = 1;
        m_IconSpriteName = "ElfIcon";
    }
    //播放音效
    public override void DoPlayHitSound()
    {
        
    }
    //播放特效
    public override void DoShowHitEffect()
    {
        PlayEffect("ElfHitEffect");
    }
    //执行Visitor
    public override void RunVisitor(ICharacterVisitor Visitor)
    {
        Visitor.VisitEnemyElf(this);
    }
}
