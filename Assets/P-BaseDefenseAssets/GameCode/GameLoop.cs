using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    SceneStateController m_sceneStateController = new SceneStateController();
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);

        UnityEngine.Random.seed = (int)DateTime.Now.Ticks;
    }
    private void Start()
    {
        m_sceneStateController.SetState(new StartState(m_sceneStateController), "");
    }
    public void Update()
    {
        m_sceneStateController.StateUpdate();
    }
}
