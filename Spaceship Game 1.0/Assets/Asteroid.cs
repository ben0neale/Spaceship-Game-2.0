using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Interactable
{
    Rigidbody RB;
    Quaternion rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
        SetHealth(100);
>>>>>>> Stashed changes
=======
        SetHealth(100);
>>>>>>> Stashed changes
=======
        SetHealth(100);
>>>>>>> Stashed changes
        RB = gameObject.GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        rotationSpeed = Quaternion.Euler(0, 0, Random.Range(0f,.7f));
        RB.AddForce(new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= rotationSpeed;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            TakeDamage(50);
            print(health);
        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
