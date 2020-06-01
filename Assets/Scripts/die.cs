using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    public void Die()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
