using UnityEngine;

public class WheelMovementScript : MonoBehaviour
{
    [SerializeField] public float speed = 100f;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
           
            transform.Rotate(Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
         
            transform.Rotate(Vector2.right * -speed * Time.deltaTime);
        }
    }
}