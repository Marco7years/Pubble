using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBubble : MonoBehaviour
{
    public GameObject bubbleSpawned;

    /* Da decidere il tipo di spawn da applicare */

    //[SerializeField] GameObject yellowBubble;
    //[SerializeField] GameObject redBubble;
    //private GameObject[] arr;

    [SerializeField] float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //arr = [blueBubble, redBubble, yellowBubble];
        StartCoroutine(bubbleWave());
    }

    private void spawnBubble()
    {
        GameObject b = Instantiate(bubbleSpawned) as GameObject;
        bubbleSpawned.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -1.3f);
    }

    IEnumerator bubbleWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBubble();
        }
    } 
}
