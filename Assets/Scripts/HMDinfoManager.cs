using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HMDinfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is Device Active :" + XRSettings.isDeviceActive);
        Debug.Log("Device Name is :" + XRSettings.loadedDeviceName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
