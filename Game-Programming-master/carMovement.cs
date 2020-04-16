using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    public float speed;
    public float gravity;
    public float jumpHeight;
    private Vector3 direction;
    private Vector3 walkingVelocity;
    private Vector3 fallingVelocity;
    private CharacterController controller;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8.0f;
        gravity = 9.8f;
        direction = Vector3.zero;
        walkingVelocity = Vector3.zero;
        fallingVelocity = Vector3.zero;
        controller = GetComponent<CharacterController>();
        audio = GetComponent<AudioSource>();
        //audio.Play(); // car sound
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        direction = direction.normalized;
        if (direction != Vector3.zero)
            transform.forward = direction;
        walkingVelocity = direction * speed;
        controller.Move(walkingVelocity * Time.deltaTime);

        fallingVelocity.y -= gravity * Time.deltaTime;

        while (Input.GetKeyDown(KeyCode.W))
        {
            audio.Play();
        }

        

        /*
        if (Input.GetButtonDown("Jump") && fallingVelocity.y <= -6)
        {
            audio.Play();
            fallingVelocity.y = Mathf.Sqrt(gravity * jumpHeight);
        }
        */
        controller.Move(fallingVelocity * Time.deltaTime);

    }

    // when the car hit an object 
    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.name == "Rock")  // the name of the object Rock
        {
            Destroy(this.gameObject);  // To destroy the car
            Destroy(obj.gameObject); // To destroy the object
        }

        if (obj.gameObject.name == "Coin")  // the name of the object Rock
        {
            Destroy(obj.gameObject); // destroy coin

        }
    }
}