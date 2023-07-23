using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningState : IPlayerAnimationState
{
    public void UpdateAnimation(PlayerController player)
    {
        // Implement running animation logic here
        player.myAnimator.SetFloat("Speed", player.myRigidbody.velocity.x);
    }
}
