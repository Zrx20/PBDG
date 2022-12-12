using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//利用Builder介面来建构物件
public class CharacterBuilderSystem : IGameSystem
{
    private int m_GameObjectID = 0;
    public CharacterBuilderSystem(PBaseDefenseGame PBDGame):base(PBDGame)
    {

    }
    public override void Initialize()
    {
       
    }
    public override void Update()
    {
        
    }
    //建立
    public void Construct(ICharacterBuilder theBuilder)
    {

        //利用Builder产生各部份加入Product中
        theBuilder.LoadAsset(++m_GameObjectID);
        theBuilder.AddOnClickScript();
        theBuilder.AddWeapon();
        theBuilder.SetCharacterAttr();
        theBuilder.AddAi();
        //加入管理器内
        theBuilder.AddCharacterSystem(m_PBDGame);
    }
}
