using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class No_name
    {
        public static void BlankName()
        {
            PhotonNetwork.LocalPlayer.NickName = "_____";
            GorillaComputer.instance.currentName = "_____";
            GorillaComputer.instance.savedName = "_____";
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", "_____");
        }
    }
}
