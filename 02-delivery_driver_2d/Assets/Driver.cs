using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Variables
    [SerializeField] float steerSpeed = 140;
    [SerializeField] float moveSpeed = 4;



    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;


        transform.Rotate(0, 0, -steerAmount);

        transform.Translate(0, moveAmount, 0);

    }
}
