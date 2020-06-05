
using UnityEngine;

public class DestroyAbove : MonoBehaviour
{
   
    void Update()
    {
        if(transform.position.y> 8)
        {
            Destroy(gameObject);
        }
    }
}
