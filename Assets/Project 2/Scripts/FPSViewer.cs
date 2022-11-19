using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPSViewer : MonoBehaviour
{
    public GameObject text;

    private const float updateInterval = 0.5f;

    private int framesCount;
    private float framesTime;

    void Update()
    {
        // monitoring frame counter and the total time
        framesCount++;
        framesTime += Time.unscaledDeltaTime;

        // measuring interval ended, so calculate FPS and display on Text
        if (framesTime > updateInterval)
        {
            if (text != null)
            {
                float fps = framesCount / framesTime;
                text.GetComponent<TextMeshPro>().text = System.String.Format("{0:F2} FPS", fps);
            }
            // reset for the next interval to measure
            framesCount = 0;
            framesTime = 0;
        }

    }
}
