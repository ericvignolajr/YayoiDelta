using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Idle : IState
{
    // Update is called once per frame
    public void Update(StateMachine stateMachine)
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            // switch to jump state
            stateMachine.ChangeState(stateMachine.PlayerJumpState);
        } else if(Input.GetAxisRaw("Horizontal") != 0) {
            stateMachine.ChangeState(stateMachine.PlayerWalkingState);
        }
        // Debug.Log("Sick Idle Here");
    }
}
