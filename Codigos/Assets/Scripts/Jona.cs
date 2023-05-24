using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jona : MonoBehaviour
{
    public float MovementSpeed = 5.5f;
    public float RotationSpeed = 200.10f;
    private Animator animator;
    public float x, y;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * RotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * MovementSpeed);

        animator.SetFloat("SpeedX", x);
        animator.SetFloat("SpeedY", y);




    }
}
