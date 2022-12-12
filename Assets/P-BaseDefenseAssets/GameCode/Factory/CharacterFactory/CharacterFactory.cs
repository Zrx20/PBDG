using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//产生游戏角色工厂
public class CharacterFactory : ICharacterFactory
{
    //角色建立指导者
    private CharacterBuilderSystem m_BuilderDirector = new CharacterBuilderSystem(PBaseDefenseGame.Instance);
    //建立Soldier
    public override ISoldier CreateSoldier(ENUM_Soldier emSoldier, ENUM_Weapon emWeapon, int Lv, Vector3 SpawnPosition)
    {
        //建立Soldier的参数
        return null;
    }

    public override IEnemy CreateEnemy(ENUM_Enemy emEnemy, ENUM_Weapon emWeapon, Vector3 SpawnPosition, Vector3 AttkackPosition)
    {
        throw new System.NotImplementedException();
    }
}
