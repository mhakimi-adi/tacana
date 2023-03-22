using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawnerScript : MonoBehaviour
{
    public GameObject sign;
    public float spawnRate;
    public float timer;
    public float heightOffset;

    // Start is called before the first frame update
    void Start()
    {
        spawnSign();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnSign();
            timer = 0;
        }
    }

    void spawnSign()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate
        (
            sign,
            new Vector3(
                transform.position.x,
                Random.Range(lowestPoint, highestPoint),
                0
            ),
            transform.rotation
        );
    }
}
