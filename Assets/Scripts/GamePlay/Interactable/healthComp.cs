
using UnityEngine;

public class healthComp : MonoBehaviour
{
    // Start is called before the first frame update
    int healingAmount = 1;
    [SerializeField] ParticleSystem effect = null;


    [SerializeField] float speed = 3f;
   

    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (effect != null)
            {
                Instantiate(effect, transform.position, Quaternion.identity);
            }
            other.GetComponent<Health>().healUp(healingAmount);
            Destroy(this.gameObject);
        }
    }
}
