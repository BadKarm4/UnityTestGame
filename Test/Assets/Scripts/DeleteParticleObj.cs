using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteParticleObj : MonoBehaviour
{
    private float startTime = 0;
    private float endTime = 2;

    private void FixedUpdate()
    {
        startTime += 1.0f * Time.deltaTime;

        if (startTime > endTime)
        {
            Destroy(gameObject);
        }
    }
}
