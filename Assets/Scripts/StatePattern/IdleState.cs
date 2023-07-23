using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IPlayerAnimationState
{
    public void UpdateAnimation(PlayerController player)
    {
        // Implement idle animation logic here
        player.myAnimator.SetFloat("Speed", 0);
    }
}
