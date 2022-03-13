using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Variables
    [SerializeField] float steerSpeed = 1;
    [SerializeField] float moveSpeed = 0.01f;



    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;


        transform.Rotate(0, 0, -steerAmount);
        // transform.Rotate(0, 0, -0.1f);


        transform.Translate(0, moveAmount, 0);

    }
}
