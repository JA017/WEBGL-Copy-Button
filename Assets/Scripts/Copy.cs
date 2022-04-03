using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices;

public class Copy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCopy() {
    #if UNITY_WEBGL        
            WebGLCopyAndPasteAPI.GetCopyClipboard("check");
    #endif        
        Debug.Log("asdsdfasddf");
    }

}
