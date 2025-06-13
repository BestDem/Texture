using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Playables;
using UnityEngine.Playables;

public class TimeLineActivate : MonoBehaviour
{
    private PlayableDirector timeLine;
    
    void Start()
    {
        timeLine = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            timeLine.Play();
    }
}
