using System;
using System.Collections.Generic;
using System.Text;

namespace HotdogPAID.Mods { }

    internal class Snaped_NECK
    {
    public static void BackwardsHead()
    {
        GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 180f;
    }

}

