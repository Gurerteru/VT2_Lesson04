using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultSceneState : IState
{
    // === メンバー変数 === //
    private SceneManager _sceneManager;

    // 状態の初期化処理
    public void Enter()
    {
        Debug.Log($"{GetType().Name}が始まります");

        // SceneManagerを取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();
    }

    // 状態の繰り返し処理
    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ゲーム画面に切り替える
            _sceneManager.ChangeScene(new TitleSceneState());
        }
    }

    // 状態の終了処理
    public void Exit()
    {
        Debug.Log($"{GetType().Name}が終了します");
    }
}
