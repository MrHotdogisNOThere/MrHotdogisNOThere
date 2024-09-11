using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Size
    {
        public static void SizeChangerMod()
        {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                sizeScale = 1f;
            }
            if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f)
            {
                sizeScale -= 0.05f;
            }
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
            {
                sizeScale += 0.05f;
            }
            if (sizeScale <= 0f)
            {
                sizeScale = 0.05f;
            }
            GorillaLocomotion.Player.Instance.scale = sizeScale;
        }
        public static float sizeScale = GorillaLocomotion.Player.Instance.scale = 1f;
    }
}
