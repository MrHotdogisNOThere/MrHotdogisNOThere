using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class ESP
    {
        public static void FullBodyESP()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (!vrrig.isOfflineVRRig)
                {
                    if (vrrig.mainSkin.material.name.Contains("fected") || vrrig.mainSkin.material.name.Contains("It"))
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader"); // Shader to make Player See Through
                        vrrig.mainSkin.material.color = new Color32(255, 0, 0, 100); // Color of Tagged Player
                    }
                    else
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader"); // Shader to make Player See Through
                        vrrig.mainSkin.material.color = new Color32(0, 255, 0, 100); // Color of Untagged Player
                    }
                }
            }
        }
        public static void DisableFullBodyESP() // This is to Disable the Full Body ESP
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig && vrrig.mainSkin.material.shader == Shader.Find("GUI/Text Shader"))
                {
                    vrrig.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
                }
            }
        }
    }
}
