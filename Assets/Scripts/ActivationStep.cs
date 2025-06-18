using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationStep : MonoBehaviour
{
    private Vector3 vector3;

    private void Start()
    {
        vector3 = transform.localScale;
    }

    public void ActivationOneStep()
    {
        StartCoroutine(FadeInAndScale());
    }

    private IEnumerator FadeInAndScale()
    {
        float duration = 0f;
        float elapsedTime = 1f;
        Vector3 startScale = new Vector3(0f, 0f, 0f);

        while (elapsedTime > duration)
        {
            duration += Time.deltaTime;
            float t = duration/elapsedTime;

            transform.localScale = Vector3.Lerp(startScale, vector3, t);

            yield return null;
        }

        transform.localScale = vector3;
    }
}
