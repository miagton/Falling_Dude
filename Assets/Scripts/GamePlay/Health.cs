
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] ParticleSystem effect = null;
    [SerializeField] int health = 3;
    [SerializeField] GameObject dieMenu = null;

    AudioSource audio;
    
    public UnityEvent Died;
    private void Awake()
    {
        dieMenu.SetActive(false);
        audio = GetComponent<AudioSource>();

    }

   
    void Update()
    {
        Die();
    }

    public void GetDamaged(int damage)
    {
        if (effect != null)
        {
            Instantiate(effect, transform);

        }
        audio.Play();
        health -= damage;
    }

    public void healUp(int amount)
    {
        if (health < 3)
        {
            health += amount;
        }
    }
    public int GetHealth()
    {
        return health;
    }
    private void Die()
    {
        if (health <= 0)
        {
            health = 0;
            Time.timeScale = 0f;
            Died.Invoke();
            dieMenu.SetActive(true);


        }
    }
}
