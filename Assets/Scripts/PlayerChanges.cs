using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerChanges : MonoBehaviour
{
    [SerializeField] float power = 1;
    private Rigidbody rigidbody;
    private Animator anim;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private IEnumerator PlayerAddPower()
    {
        float time = 2;
        while (time > 0)
        {
            time -= Time.deltaTime;
            rigidbody.AddForce(0, power, 0, ForceMode.Force);
            yield return null;
        }
    }

    public void AddingPower()
    {
        StartCoroutine(PlayerAddPower());
    }

    public void DellObject()
    {
        Destroy(this.gameObject);
    }

    public void PlayerAnimationWalk()
    {
        anim.SetBool("Walk", true);
    }
}
