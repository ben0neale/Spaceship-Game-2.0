using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Interactable
{
    [SerializeField] CharacterController CH;
    Type type;
    public float acceleration = 100f;
    public float maxSpeed = 500f;
    Vector2 playerInput;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        type = Type.Player;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        moveDirection = new Vector2(playerInput.x * acceleration * Time.deltaTime, playerInput.y * acceleration * Time.deltaTime);
        CH.Move(moveDirection);

        if (moveDirection != Vector2.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(Vector3.forward, moveDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotate, 10f * Time.deltaTime);
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        Destroy(hit.gameObject);
        Destroy(gameObject);
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        
        if (hit.gameObject.tag == "object")
        {
            Destroy(gameObject);
            Destroy(hit.gameObject);
        }
        
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }

    private void OnMove(InputValue iv)
    {
        playerInput = iv.Get<Vector2>();
    }

}
