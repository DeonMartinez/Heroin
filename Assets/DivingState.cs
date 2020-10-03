using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingState : IStates
{
    public float diveForce = -30f;
    public void Enter(Player player)
    {
        player.mCurrentState = new DivingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, diveForce, 0);
        Debug.Log("Enter Diving state");
    }

    public void Execute(Player player)
    {
        if (Physics.Raycast(player.transform.position, Vector3.down,1f))
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

    }
}
