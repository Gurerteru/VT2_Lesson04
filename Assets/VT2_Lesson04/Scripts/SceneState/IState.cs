using UnityEditor;
using UnityEngine;

/// <summary>
/// インターフェース(interfae)
/// -＞ このインターフェースを継承するクラスは、
///　　 記述されているメソッドやプロパティをすべて実装しなければならない
/// </summary>
public interface IState
{
    void Enter();       // 状態の初期化処理
    void Execute();     // 状態の繰り返し処理
    void Exit();        // 状態の終了処理
}

/// <summary>
/// 貝象クラスに継承させる抽象クラス
/// </summary>
public abstract class BaseSceneState : IState
{
    // === 親クラスのメンバー === //
    protected SceneManager _sceneManager;

    // === Canvas 設定プロパティ === //
    // ヘッドアップディスプレイ(UI)のプレハブのアドレスを入力
    public abstract string HudAddress { get; protected set; }

    // 状態の初期化処理
    public virtual void Enter()
    {
        Debug.Log($"{GetType().Name}が始まります");

        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        // === プレハブの読み込み === //
        GameObject hudPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(HudAddress);
        GameObject.Instantiate(hudPrefab);
    }

    // 状態の繰り返し処理
    public virtual void Execute()
    {

    }

    // 状態の終了処理
    public virtual void Exit()
    {
        Debug.Log($"{GetType().Name}が終了します");
    }
}
