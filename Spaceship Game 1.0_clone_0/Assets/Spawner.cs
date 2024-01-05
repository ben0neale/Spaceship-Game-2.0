using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Ship;
    [SerializeField] List<GameObject> asteroids;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(asteroids[Random.Range(0, asteroids.Count)], new Vector3(Random.Range(Ship.transform.position.x - 15, Ship.transform.position.x + 15), Random.Range(Ship.transform.position.y - 15, Ship.transform.position.y + 15), 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
