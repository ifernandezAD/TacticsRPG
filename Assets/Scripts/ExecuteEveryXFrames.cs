using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteEveryXFrames : MonoBehaviour
{
    public int frameInterval;

    private void Update()
    {
        if (Time.frameCount % frameInterval == 0)
        {
            Debug.Log("I am Ironman");
        }
    }
}
