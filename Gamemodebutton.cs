using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Gamemodebutton
    {
        public static void DisableGamemodeButtons()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/ModeSelector_Group").SetActive(false);
        }

    }
}
