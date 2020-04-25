using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0,1.0f,0);
        transform.position += direction * Time.deltaTime * speed;
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }

}
