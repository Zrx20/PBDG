using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityTool 
{
    public static void Attack(GameObject ParentObj,GameObject ChildObj,Vector3 pos)
    {
        ChildObj.transform.parent = ParentObj.transform;
        ChildObj.transform.localPosition = pos;
    }
    public static void AttackToRefPos(GameObject ParentObj,GameObject ChildObj,string RefPointName,Vector3 pos)
    {
        bool bFinded = false;
        Transform[] allChildren = ParentObj.transform.GetComponentsInChildren<Transform>();
        Transform RefTransform = null;
        foreach (Transform child in allChildren)
        {
            if (child.name == RefPointName)
            {
                if (bFinded == true)
                {
                    Debug.LogWarning("物件[" + ParentObj.transform.name + "]内有两个以上的参考点[" + RefPointName + "]");
                    continue;
                }
                bFinded = true;
                RefTransform = child;
            }
        }
        if (bFinded == false)
        {
            Debug.LogWarning("物件[" + ParentObj.transform.name + "]内没有参考点[" + RefPointName + "]");
            Attack(ParentObj, ChildObj, pos);
            return;
        }
        ChildObj.transform.parent = RefTransform;
        ChildObj.transform.localPosition = pos;
        ChildObj.transform.localScale = Vector3.one;
        ChildObj.transform.localRotation = Quaternion.Euler(Vector3.zero);
    }
    public static GameObject FindGameObject(string GameObjectName)
    {
        GameObject pTmpGameObj = GameObject.Find(GameObjectName);
        if (pTmpGameObj == null)
        {
            Debug.LogWarning("场景中找不到GameObject[" + GameObjectName + "]事件");
            return null;
        }
        return pTmpGameObj;
    }
    public static GameObject FindChildGameObject(GameObject Container,string gameobjectName)
    {
        if (Container == null)
        {
            Debug.LogError("NGUICustomTools.GetChild:Container == null");
            return null;
        }
        Transform pGameObjectTF = null;
        if (Container.name == gameobjectName)
        {
            pGameObjectTF = Container.transform;
        }
        else
        {
            Transform[] allChildren = Container.transform.GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
                if (child.name == gameobjectName)
                {
                    if (pGameObjectTF == null)
                    {
                        pGameObjectTF = child;
                    }
                    else
                    {
                        Debug.LogWarning("Container[" + Container.name + "]下找出重复的元件名称[" + gameobjectName + "]");
                    }
                }
            }
        }
        if (pGameObjectTF == null)
        {
            Debug.LogError("元件[" + Container.name + "]找不到子元件[" + gameobjectName + "]");
            return null;
        }
        return pGameObjectTF.gameObject;
    }
}
