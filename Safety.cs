using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using BepInEx;
using ExitGames.Client.Photon;
using GorillaTag.GuidedRefs;
using Photon.Realtime;
using PlayFab.ClientModels;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using static StupidTemplate.Classes.RigManager;
using static StupidTemplate.Menu.Main;
using static StupidTemplate.Mods.Global;
using static UnityEngine.Object;
using static UnityEngine.UI.CanvasScaler;
using StupidTemplate.Classes;
using StupidTemplate.Notifications;
using Oculus.Platform;
using UnityEngine.Animations.Rigging;


namespace HotdogPAID.Mods
{
    internal class Safety
    {
       
        public static void DisableNetworkTriggers()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(false);
        }
        public static void EnableNetworkTriggers()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(true);
        }
    }
}
