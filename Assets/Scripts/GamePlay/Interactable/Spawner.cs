
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePatterns = null;

    float timeBetweenSpawn;
   [SerializeField] float startTimeBetweenSpawn;
    [SerializeField] float decreaseTime;
    [SerializeField] float minTime = 0.65f;
    
  

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            int i = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[i], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;
            if (startTimeBetweenSpawn > minTime)
            {
                startTimeBetweenSpawn -= decreaseTime;
            }
            
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
