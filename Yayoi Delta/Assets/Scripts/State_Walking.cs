using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Walking : IState 
{
    // Update is called once per frame
    public void Update(StateMachine stateMachine) {
        if(Input.GetAxisRaw("Horizontal") == 0) {
            stateMachine.ChangeState(stateMachine.PlayerIdleState);
        }
        Debug.Log("Sweet Walking Animation plays");
    }
}
