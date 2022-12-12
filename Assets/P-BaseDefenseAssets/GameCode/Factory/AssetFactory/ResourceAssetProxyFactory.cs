using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//做为ResourceAssetFactory的Proxy代理者,会记录已经载入过的资源
public class ResourceAssetProxyFactory : IAssetFactory
{
    private ResourceAssetFactory m_RealFactory = null;//实际负责载入的AssetFactory
    private Dictionary<string, UnityEngine.Object> m_Soldiers = null;
    private Dictionary<string, UnityEngine.Object> m_Enemys = null;
    private Dictionary<string, UnityEngine.Object> m_Weapons = null;
    private Dictionary<string, UnityEngine.Object> m_Effects = null;
    private Dictionary<string, AudioClip> m_Audios = null;
    private Dictionary<string, Sprite> m_Sprites = null;

    public ResourceAssetProxyFactory()
    {
        m_RealFactory = new ResourceAssetFactory();
        m_Soldiers = new Dictionary<string, Object>();
        m_Enemys = new Dictionary<string, Object>();
        m_Weapons = new Dictionary<string, Object>();
        m_Enemys = new Dictionary<string, Object>();
        m_Audios = new Dictionary<string, AudioClip>();
        m_Sprites = new Dictionary<string, Sprite>();
    }
    //产生AudioClip
    public override AudioClip LoadAudioClip(string ClipName)
    {
        if (m_Audios.ContainsKey(ClipName) == false)
        {
            Object res = m_RealFactory.LoadGameObjectFromResourcePath(ResourceAssetFactory.AudioPath + ClipName);
            m_Audios.Add(ClipName, res as AudioClip);
        }
        return m_Audios[ClipName];
    }
    //产生特效
    public override GameObject LoadEffect(string ClipName)
    {
        if (m_Effects.ContainsKey(ClipName) == false)
        {
            Object res = m_RealFactory.LoadGameObjectFromResourcePath(ResourceAssetFactory.EffectPath + ClipName);
            m_Effects.Add(ClipName, res);
        }
        return Object.Instantiate(m_Effects[ClipName]) as GameObject;
    }

    //产生Enemy
    public override GameObject LoadEnemy(string AsstName)
    {
        if (m_Enemys.ContainsKey(AsstName) == false)
        {
            Object res = m_RealFactory.LoadGameObjectFromResourcePath(ResourceAssetFactory.EnemyPath + AsstName);
            m_Enemys.Add(AsstName, res);
        }
        return Object.Instantiate(m_Enemys[AsstName]) as GameObject;
    }
    //产生Soldier
    public override GameObject LoadSoldier(string AssetName)
    {
        //还没载入时
        if (m_Soldiers.ContainsKey(AssetName) == false)
        {
            Object res = m_RealFactory.LoadGameObjectFromResourcePath(ResourceAssetFactory.SoldierPath + AssetName);
            m_Soldiers.Add(AssetName, res);
        }
        return Object.Instantiate(m_Soldiers[AssetName]) as GameObject;
    }
    //产生Sprite
    public override Sprite LoadSprite(string SpriteName)
    {
        if (m_Sprites.ContainsKey(SpriteName) == false)
        {
            Sprite res = m_RealFactory.LoadSprite(SpriteName);
            m_Sprites.Add(SpriteName, res);
        }
        return m_Sprites[SpriteName];
    }
    //产生Weapon
    public override GameObject LoadWeapon(string AsstName)
    {
        if (m_Weapons.ContainsKey(AsstName) == false)
        {
            Object res = m_RealFactory.LoadGameObjectFromResourcePath(ResourceAssetFactory.WeaponPath + AsstName);
            m_Weapons.Add(AsstName, res);
        }
        return Object.Instantiate(m_Weapons[AsstName] as GameObject);
    }
}
