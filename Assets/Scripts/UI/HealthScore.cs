
using TMPro;
using UnityEngine;
using System;

public class HealthScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthScore = null;
    Health health;
    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    }


    void Update()
    {
        healthScore.text =String.Format("{0:0}", health.GetHealth()) ;
    }
}
