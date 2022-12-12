using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface TCharacterFactory_Generic 
{
    ISoldier CreateSoldier<T>(ENUM_Weapon enWeapon, int lv, Vector3 SpawnPosition) where T : ISoldier, new();

    
}
