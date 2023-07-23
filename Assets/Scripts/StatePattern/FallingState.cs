using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingState : IPlayerAnimationState
{
    public void UpdateAnimation(PlayerController player)
    {
        // Implement falling animation logic here
        // You may need to add more conditions to distinguish between jumping and falling
        player.myAnimator.SetBool("Grounded", false);
    }
}
