using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase : MonoBehaviour
{
    public virtual void OnEnter(){ }//その状態の最初にやる処理
    public virtual void OnUpdate() { }//その状態で毎フレームやる処理
    public virtual void OnExit() { }//その状態の最後にやる処理
}
