using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Longarms
    {
        public static void LongArmsMod()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new UnityEngine.Vector3(1.2f, 1.2f, 1.2f);
            
        }
    }
}
