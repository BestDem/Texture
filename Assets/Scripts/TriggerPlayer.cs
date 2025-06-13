using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerPlayer : MonoBehaviour
{
    [SerializeField] private PlayableDirector timeLineTalk;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeLineTalk.Play();
            Destroy(this);
        }
    }
}
