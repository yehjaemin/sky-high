using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    private float horizontal = 0f;
    private bool jump = false;
    private bool fall = false;

    public float runSpeed = 40f;


    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * runSpeed;
        jump = Input.GetButtonDown("Jump");
        fall = Input.GetAxisRaw("Vertical") < 0;
    }

    private void FixedUpdate()
    {
        controller.Move(horizontal * Time.fixedDeltaTime, fall, jump);
        jump = false;
    }
}
