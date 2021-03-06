﻿
using UnityEngine;

public class DestroyAfterEffect : MonoBehaviour
{
    [SerializeField] GameObject TargetToDestroy = null;
    void Update()
    {
        if (!GetComponent<ParticleSystem>().IsAlive())
        {
            if (TargetToDestroy != null)
            {
                Destroy(TargetToDestroy);
            }
            else
                Destroy(gameObject);
        }
    }
}
