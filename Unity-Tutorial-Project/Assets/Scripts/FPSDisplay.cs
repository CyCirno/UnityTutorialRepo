using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class FPSDisplay : MonoBehaviour
{

    int FrameCount = 0;
    public TMP_Text frameRateDisplay = null;
    private static float frameCount;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float frameRate = frameCount / Time.time;
        frameRateDisplay.text = frameRate.ToString();
    }
}
