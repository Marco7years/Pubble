using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowController : MonoBehaviour
{
    Rigidbody2D rb2D;
    float coolDown = -1.0f;
    float timeToCoolDown = 1.0f;
    [SerializeField] float speed = 2.0f;
    float horizontal = 0f;

    private void Awake()
    {
       rb2D = gameObject.GetComponent<Rigidbody2D>();
       rb2D.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = speed * Time.deltaTime;
        int randomDirection = Random.Range(-1, 2);
        Debug.Log($"{randomDirection}");

        if (coolDown < 0)
        {
            coolDown = timeToCoolDown;
            Debug.Log($"CoolDown-->{coolDown}");
            horizontal = randomDirection * speed * Time.deltaTime;
        }

        Vector3 newPosition = transform.position + new Vector3(horizontal, vertical, 0f);
        rb2D.MovePosition(newPosition);
        coolDown -= Time.deltaTime;
    }
}
