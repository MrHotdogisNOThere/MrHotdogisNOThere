using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class CompSpeed
    {
        public static void SpeedboostMod1()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 8f; // Speed
            GorillaLocomotion.Player.Instance.jumpMultiplier = 2f; // Speed Multiplier
        }
    }
}
