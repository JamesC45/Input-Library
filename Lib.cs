using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InputLibrary
{
    public class Lib : MonoBehaviour
    {
        // Inputs.
        public enum buttonsreturned
        {
            Trigger,
            Grip,
            Primary,
            Secondary
        }
        public bool GetBtn(bool R, buttonsreturned btnsret)
        {
            if (btnsret == buttonsreturned.Trigger)
            {
                return (R == true) ? ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f : ControllerInputPoller.instance.leftControllerIndexFloat > 0.5f;
            }
            if (btnsret == buttonsreturned.Grip)
            {
                return (R == true) ? ControllerInputPoller.instance.rightGrab : ControllerInputPoller.instance.leftGrab;
            }    
            if (btnsret == buttonsreturned.Primary)
            {
                return (R == true) ? ControllerInputPoller.instance.rightControllerPrimaryButton : ControllerInputPoller.instance.leftControllerPrimaryButton;
            }  
            if (btnsret == buttonsreturned.Secondary)
            {
                return (R == true) ? ControllerInputPoller.instance.rightControllerSecondaryButton : ControllerInputPoller.instance.leftControllerSecondaryButton;
            }
            return false;
        }

        // Handling instance
        private static Lib _instance;
        public static Lib Instance => _instance;

    }
}
