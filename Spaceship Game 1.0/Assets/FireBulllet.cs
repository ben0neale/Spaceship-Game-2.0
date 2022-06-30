using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FireBulllet : MonoBehaviour
{
    [SerializeField] GameObject ship;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject spawnpoint;
    Touch isFire;

    Keyboard keybo = Keyboard.current;

    // Update is called once per frame
    void Update()
    {
        if (keybo.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bullet, spawnpoint.transform.position, ship.transform.rotation * Quaternion.Euler(0,0,90));
        }
    }

    void OnFire(InputValue iv)
    {
        isFire = iv.Get<Touch>();
    }
}
