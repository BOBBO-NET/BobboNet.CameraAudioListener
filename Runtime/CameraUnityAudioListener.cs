using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BobboNet.CameraAudioListener
{
    public class CameraUnityAudioListener : ICameraAudioListener
    {
        public void Setup(Camera mainCamera)
        {
            mainCamera.gameObject.AddComponent<AudioListener>();
        }
    }

}
