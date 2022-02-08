using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Jump : IState
{

    // Update is called once per frame
    public void Update(StateMachine stateMachine)
    {
        Debug.Log("Sick Jump Here");

        // this is not the ultimate intended behavior, the player will switch
        // to the idle animation automatically after the jump completes but
        // for debugging purposes the player will stay in the jump state until
        // the space bar is pressed again
        // if(Input.GetKeyDown(KeyCode.Space)) {
        //     // switch to jump state
        //     stateMachine.ChangeState(stateMachine.PlayerIdleState);
        // }
    }
}
