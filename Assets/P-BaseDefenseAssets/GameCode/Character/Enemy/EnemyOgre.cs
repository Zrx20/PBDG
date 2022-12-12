﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOgre : IEnemy
{
    public EnemyOgre()
    {
        m_emEnemyType = ENUM_Enemy.Ogre;
        m_AssetName = "Enemy3";
        m_AttrID = 3;
        m_IconSpriteName = "OgreIcon";
    }
    //播放音效
    public override void DoPlayHitSound()
    {
        
    }
    //播放特效
    public override void DoShowHitEffect()
    {
        PlayEffect("OgreHitEffect");
    }
    //执行Visitor
    public override void RunVisitor(ICharacterVisitor Visitor)
    {
        Visitor.VisitEnemyOgre(this);
    }
}
