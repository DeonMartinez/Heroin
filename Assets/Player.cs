using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public IStates mCurrentState;

    void Awake()
    {
        mCurrentState = new StandingState();
        mCurrentState.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        mCurrentState.Execute(this);    
    }
}
