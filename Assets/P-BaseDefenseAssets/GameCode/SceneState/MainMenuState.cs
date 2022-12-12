using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//主选单状态
public class MainMenuState : ISceneState
{
   public MainMenuState(SceneStateController controller):base(controller)
    {
        this.StateName = "MainMenuState";
    }
    public override void StateBegin()
    {
        Button tmpBtn = UITool.GetUIComponent<Button>("StartGameBtn");
        if (tmpBtn != null)
            tmpBtn.onClick.AddListener( OnStartGameBtnClick);
    }
    private void OnStartGameBtnClick()
    {
        m_Controller.SetState(new BattleState(m_Controller), "BattleScene");
    }
}
