using System;
using System.Collections.Generic;
using System.Text;

namespace HotdogPAID.Mods
{
    internal class GhostMOnke
    {
        public static void GhostMonke()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}
