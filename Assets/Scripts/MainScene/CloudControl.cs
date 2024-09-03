using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudControl : MonoBehaviour
{
    [SerializeField] GameObject cloud;

    void Start()
    {
        StartCoroutine(CreateCloud());
    }

    IEnumerator CreateCloud()
    {
        while (true)
        {
            GameObject o = Instantiate(cloud);
            o.transform.SetParent(transform);
            o.transform.localPosition = new Vector3(1066, Random.Range(-75, 470), 0);
            o.gameObject.SetActive(true);
            yield return new WaitForSeconds(Random.Range(10, 20));
        }
    }
}
