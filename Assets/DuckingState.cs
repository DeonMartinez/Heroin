using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingState : IStates
{
    public void Enter(Player player)
    {
        player.mCurrentState = new DuckingState();
        player.transform.localScale *= 0.5f;
        Debug.Log("Enter Ducking state");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SuperJumpingState superJumpingState = new SuperJumpingState();
            superJumpingState.Enter(player);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            player.transform.localScale *= 2f;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

    }
}
