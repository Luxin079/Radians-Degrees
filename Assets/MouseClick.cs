using System.Linq;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Vector3 mouseposition;
    Vector3 differenceVector;
    Vector3 direction;
    float distance;
    [SerializeField] private bullet preFabBullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseposition = Input.mousePosition;
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            differenceVector = mouseposition - transform.position;
            distance = differenceVector.magnitude;
            direction = differenceVector.normalized;

            bullet Bullet = Instantiate(preFabBullet, transform.position, Quaternion.identity);

            // Set bullet velocity if it has a Rigidbody2D
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = direction * 10f; // 10f is bullet speed, adjust as needed
            }
        }
    }
}