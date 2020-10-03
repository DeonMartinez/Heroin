using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IStates
{

    public float jumpTime;
    public float jumpForce = 10f;
    public float superJumpForce = 20f;

    public void Enter(Player player)
    {
        player.mCurrentState = new JumpingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, jumpForce, 0);
        Debug.Log("Enter Jumping state");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            DivingState divingState = new DivingState();
            divingState.Enter(player);
        }

        jumpTime += Time.time;

        if (Physics.Raycast(player.transform.position, Vector3.down, 1f) && 2 * jumpTime > Time.time)
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
