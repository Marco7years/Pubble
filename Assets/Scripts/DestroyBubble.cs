using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBubble : MonoBehaviour
{
    void OnBecameInvisible()
    {    
        Destroy(gameObject);
    }
}
