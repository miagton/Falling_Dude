using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    
    [SerializeField] float speed = 0.05f;
    [SerializeField] int damage = 1;

    private void Update()
    {
        transform.Translate(Vector3.up * speed*Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag( "Player"))
        {
          
            other.GetComponent<Health>().GetDamaged(damage);
           
            Destroy(this.gameObject);
        }
        
    }
}
