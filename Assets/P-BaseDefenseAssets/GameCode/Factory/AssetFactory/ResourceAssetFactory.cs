using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceAssetFactory : IAssetFactory
{
    public const string SoldierPath = "Characters/Soldier/";
    public const string EnemyPath = "Charactters/Enemy/";
    public const string WeaponPath = "Weapons/";
    public const string EffectPath = "Effects";
    public const string AudioPath = "Audios/";
    public const string SpritePath = "Sprites/";
    //产生AudioClip
    public override AudioClip LoadAudioClip(string ClipName)
    {
        UnityEngine.Object res = LoadGameObjectFromResourcePath(AudioPath + ClipName);
        if (res == null)
            return null;
        return res as AudioClip;
    }
    //产生Soldier
    public override GameObject LoadEnemy(string AsstName)
    {
        return InstantiateGameObject(SoldierPath + AsstName);
    }
    //产生Soldier
    public override GameObject LoadSoldier(string AssetName)
    {
        return InstantiateGameObject(SoldierPath + AssetName);
    }
    //产生Sprite
    public override Sprite LoadSprite(string SpriteName)
    {
        return Resources.Load(SpritePath + SpriteName, typeof(Sprite)) as Sprite;
    }
    //产生Weapon
    public override GameObject LoadWeapon(string AsstName)
    {
        return InstantiateGameObject(WeaponPath + AsstName);
    }
    //产生GameObject
    private GameObject InstantiateGameObject(string AssetName)
    {
        //从Resrouce中载入
        UnityEngine.Object res = LoadGameObjectFromResourcePath(AssetName);
        if (res == null)
            return null;
        return UnityEngine.Object.Instantiate(res) as GameObject;
    }
    //从Resrouce中载入
    public UnityEngine.Object LoadGameObjectFromResourcePath(string AssetPath)
    {
        UnityEngine.Object res = Resources.Load(AssetPath);
        if (res == null)
        {
            Debug.LogWarning("无法载入路径[" + AssetPath + "]上的Asset");
            return null;
        }
        return res;
    }

    public override GameObject LoadEffect(string ClipName)
    {
        return InstantiateGameObject(EffectPath + ClipName);
    }
}
