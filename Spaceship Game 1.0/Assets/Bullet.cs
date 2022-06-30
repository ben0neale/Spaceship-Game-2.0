using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody RB;
    [SerializeField] GameObject miniExplosion;
    Vector2 speed = new Vector2(9, 9);

    // Start is called before the first frame update
    void Start()
    {
        RB.velocity = transform.right * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(miniExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
