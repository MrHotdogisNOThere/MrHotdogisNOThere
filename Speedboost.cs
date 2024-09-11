using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Speedboost
    {
        public static void SpeedboostMod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 7f; // Speed
            GorillaLocomotion.Player.Instance.jumpMultiplier = 2f; // Speed Multiplier
        }
    }
}
