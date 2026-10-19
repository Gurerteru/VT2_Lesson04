using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseSceneState : BaseSceneState
{

    // === HUDİ’è === //
    public override string HudAddress { get; protected set; } = "Assets/VT2_Lesson04/Prefab/PauseHUDCanvas_FUllHD.prefab";

    // ó‘Ô‚Ì‰Šú‰»ˆ—
    public override void Enter()
    {
        base.Enter();
    }

    public override void Execute()
    {
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene(new GameSceneState());
        }

        base.Execute();
    }
}
