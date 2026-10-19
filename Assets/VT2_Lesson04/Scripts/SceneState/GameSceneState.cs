using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameSceneState : BaseSceneState
{
    // === HUD設定 === //
    public override string HudAddress { get; protected set; } = "Assets/VT2_Lesson04/Prefab/GameHUDCanvas_FUllHD 1.prefab";

    private GameObject _gameCube;

    // 状態の初期化処理
    public override void Enter()
    {
        base.Enter();

        // オブジェクトを生成する
        _gameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // 状態の繰り返し処理
    public override void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ゲーム画面に切り替える
            _sceneManager.ChangeScene(new ResultSceneState());

            // キャラクターを消す
            GameObject.Destroy(_gameCube);
        }

        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            // PauseSceneState へ遷移
            _sceneManager.ChangeScene(new PauseSceneState());
        }

        base.Execute();
    }

    // 状態の終了処理
    public override void Exit()
    {
        base.Exit();

        GameObject.Destroy( _gameCube );
    }
}
