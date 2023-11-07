using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class focus : MonoBehaviour
{

    private bool mVuforiaStarted = false;

    private void Update()
    {
        mVuforiaStarted = true;

        // Enable focus mode:
        bool autofocusOK = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (autofocusOK)
        {
        }
        else
        {
            // set a different focus mode (for example, FOCUS_NORMAL):
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_NORMAL);

            // Other possible options:
            // CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_MACRO);
            // CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_INFINITY);
        }
    }
}