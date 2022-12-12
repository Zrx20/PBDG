using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class UITool 
{
    private static GameObject m_CanvasObj = null;
    public static void ReleaseCanvas()
    {
        m_CanvasObj = null;
    }
    //找寻限定在Canvas画布下的UI界面
    public static GameObject FindUIGameObject(string UIName)
    {
        if (m_CanvasObj == null)
        {
            m_CanvasObj = UnityTool.FindGameObject("Canvas");
        }
        if (m_CanvasObj == null)
        {
            return null;
        }
        return UnityTool.FindChildGameObject(m_CanvasObj, UIName);
    }
    public static T GetUIComponent<T>(GameObject Container,string UIName) where T:UnityEngine.Component
    {
        GameObject ChildGameObject = UnityTool.FindChildGameObject(Container, UIName);
        if (ChildGameObject == null)
        {
            return null;
        }
        T tempObj = ChildGameObject.GetComponent<T>();
        if (tempObj == null)
        {
            Debug.LogWarning("元件[" + UIName + "]不是[" + typeof(T) + "]");
            return null;
        }
        return tempObj;
    }
    public static Button GetButton(string BtnName)
    {
        GameObject UIRoot = GameObject.Find("Canvas");
        if (UIRoot == null)
        {
            Debug.LogWarning("场景删没有UI Canvas");
            return null;
        }
        Transform[] allChildren = UIRoot.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            if (child.name == BtnName)
            {
                Button tmpBtn = child.gameObject.GetComponent<Button>();
                if (tmpBtn == null)
                {
                    Debug.LogWarning("UI原件[" + BtnName + "]不是Button");
                }
                return tmpBtn;
            }
        }
        Debug.LogWarning("UI Canvas中没有Button[" + BtnName + "]存在");
        return null;
    }
    public static T GetUIComponent<T>(string UIName) where T:UnityEngine.Component
    {
        GameObject UIRoot = GameObject.Find("Canvas");
        if (UIRoot == null)
        {
            Debug.LogWarning("场景上没有UI Canvas");
            return null;
        }
        return GetUIComponent<T>(UIRoot, UIName);
    }
}
