using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public readonly IState PlayerIdleState = new State_Idle();
    public readonly IState PlayerJumpState = new State_Jump();
    public readonly IState PlayerWalkingState = new State_Walking();
    [SerializeField] private CharController PlayerCharController;
    public IState State { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        this.State = PlayerIdleState;
    }

    // Update is called once per frame
    void Update()
    {
        this.State.Update(this);
    }

    public void ChangeState(IState stateToChangeTo) {
        this.State = stateToChangeTo;
    }
    
}
