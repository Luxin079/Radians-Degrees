using UnityEngine;

public class CarMovementScript : MonoBehaviour
{
    

    [SerializeField] private float speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
