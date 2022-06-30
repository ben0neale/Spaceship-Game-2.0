using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    [SerializeField] Rigidbody2D RB;
=======
    [SerializeField] Rigidbody RB;
>>>>>>> Stashed changes
=======
    [SerializeField] Rigidbody RB;
>>>>>>> Stashed changes
=======
    [SerializeField] Rigidbody RB;
>>>>>>> Stashed changes
    Vector2 speed = new Vector2(9, 9);

    // Start is called before the first frame update
    void Start()
    {
        RB.velocity = transform.right * speed;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }

}
