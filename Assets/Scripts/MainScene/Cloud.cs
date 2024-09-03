using System.Collections;
using TMPro;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(yMovement());
    }

    void FixedUpdate()
    {
        transform.position -= new Vector3(Time.fixedDeltaTime * 40, 0, 0);
        if (transform.position.x < -1200)
            Destroy(gameObject);

    }

    IEnumerator yMovement()
    {
        int flag;
        float randMaxY, deltaY;

        while (true)
        {
            randMaxY = Time.fixedDeltaTime * Random.Range(3f, 6f);
            flag = 1;
            while (0 < randMaxY)
            {
                deltaY = Time.fixedDeltaTime * 20 * flag;
                transform.position += new Vector3(0, deltaY, 0);
                randMaxY -= deltaY;
                yield return new WaitForFixedUpdate();
            }
            randMaxY = Time.fixedDeltaTime * Random.Range(-6f, -3f);
            flag = -1;
            while (randMaxY < 0)
            {
                deltaY = Time.fixedDeltaTime * 20 * flag;
                transform.position += new Vector3(0, deltaY, 0);
                randMaxY -= deltaY;
                yield return new WaitForFixedUpdate();
            }
        }
    }
}
