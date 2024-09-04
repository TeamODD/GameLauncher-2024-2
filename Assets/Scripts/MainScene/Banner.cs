using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banner : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // StartCoroutine(yMovement());
    }

    IEnumerator yMovement()
    {
        float targetY, speed = 20;
        while (true)
        {
            targetY = transform.position.y + 20;
            speed = 20;
            while (transform.position.y < targetY)
            {
                rb.velocity = new Vector3(0, speed, 0);
                speed -= 0.1f;
                yield return new WaitForFixedUpdate();
            }
            rb.velocity = Vector3.zero;

            targetY = transform.position.y - 20;
            speed = 20;
            while (targetY < transform.position.y)
            {
                rb.velocity = new Vector3(0, speed * -1, 0);
                speed -= 0.1f;
                yield return new WaitForFixedUpdate();
            }
            rb.velocity = Vector3.zero;
        }
    }
}
