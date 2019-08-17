using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace VrGrabber
{
    public class VrgSteamVRContorollerDevice : IDevice
    {
        public SteamVR_Action_Pose actionPose;
        public SteamVR_Action_Boolean Click;
        public SteamVR_Action_Vector2 Coord;
        public SteamVR_Action_Single Hold;
        public SteamVR_Action_Boolean Hover;

        public SteamVR_Input_Sources GetInputSource(ControllerSide side)
        {
            return side == ControllerSide.Left ? SteamVR_Input_Sources.LeftHand : SteamVR_Input_Sources.RightHand;
        }

        public bool GetClick(ControllerSide side)
        {
            return Click.GetState(GetInputSource(side));
        }

        public Vector2 GetCoord(ControllerSide side)
        {
            return Coord.GetAxis(GetInputSource(side));
        }

        public float GetHold(ControllerSide side)
        {
            return Hold.GetAxis(GetInputSource(side));
        }

        public bool GetHover(ControllerSide side)
        {
            return Hover.GetState(GetInputSource(side));
        }

        public Vector3 GetLocalPosition(ControllerSide side)
        {
            return actionPose[GetInputSource(side)].localPosition;
        }

        public Quaternion GetLocalRotation(ControllerSide side)
        {
            return actionPose[GetInputSource(side)].localRotation;
        }
    }
}