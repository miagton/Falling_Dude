
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    private void Awake()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
           Touch touch= Input.GetTouch(0);
         Vector3 touchPosition =   Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            print(touchPosition);
            transform.position = Vector3.MoveTowards(transform.position, touchPosition, speed * Time.deltaTime);
        }
    }
}
