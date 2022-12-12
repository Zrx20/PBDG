using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteAssetFactory : IAssetFactory
{
    public override AudioClip LoadAudioClip(string ClipName)
    {
        return null;
    }

    public override GameObject LoadEffect(string ClipName)
    {
        return null;
    }

    public override GameObject LoadEnemy(string AsstName)
    {
        return null;
    }

    public override GameObject LoadSoldier(string AssetName)
    {
        return null;
    }

    public override Sprite LoadSprite(string SpriteName)
    {
        return null;
    }

    public override GameObject LoadWeapon(string AsstName)
    {
        return null;
    }
}
