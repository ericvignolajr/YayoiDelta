using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
    // Update is called once per frame
    void Update(StateMachine stateMachine);
}
