using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

    public class JumpingState: IPlayerAnimationState
{
    public void UpdateAnimation(PlayerController player)
    {
        // Implement jumping animation logic here
        player.myAnimator.SetBool("Grounded", false);
    }
}
