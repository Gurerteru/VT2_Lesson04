using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameSceneState : IState
{
    // === メンバー変数 === //
    private SceneManager _sceneManager;

    private GameObject _gameCube;

    // 状態の初期化処理
    public void Enter()
    {
        Debug.Log($"{GetType().Name}が始まります");

        // SceneManagerを取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        // オブジェクトを生成する
        _gameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // 状態の繰り返し処理
    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ゲーム画面に切り替える
            _sceneManager.ChangeScene(new ResultSceneState());
        }
    }

    // 状態の終了処理
    public void Exit()
    {
        Debug.Log($"{GetType().Name}が終了します");

        GameObject.Destroy( _gameCube );
    }
}
