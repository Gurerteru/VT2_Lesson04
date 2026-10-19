using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultSceneState : BaseSceneState
{
    // === HUDİ’è === //
    public override string HudAddress { get; protected set; } = "Assets/VT2_Lesson04/Prefab/ResultHUDCanvas_FUllHD.prefab";

    // ó‘Ô‚Ì‰Šú‰»ˆ—
    public override void Enter()
    {
        base.Enter();
    }

    // ó‘Ô‚ÌŒJ‚è•Ô‚µˆ—
    public override void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ƒQ[ƒ€‰æ–Ê‚ÉØ‚è‘Ö‚¦‚é
            _sceneManager.ChangeScene(new TitleSceneState());
        }

        base.Execute();
    }
}
