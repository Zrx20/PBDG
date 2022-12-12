using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAssetFactory
{
    //产生Soldier
    public abstract GameObject LoadSoldier(string AssetName);
    //产生Enemy
    public abstract GameObject LoadEnemy(string AsstName);
    //产生Weapon
    public abstract GameObject LoadWeapon(string AsstName);
    //产生特效
    public abstract GameObject LoadEffect(string ClipName);
    //产生AudioClip
    public abstract AudioClip LoadAudioClip(string ClipName);
    //产生Sprite
    public abstract Sprite LoadSprite(string SpriteName);

}
