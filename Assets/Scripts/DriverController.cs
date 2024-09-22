using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    [SerializeField] float setirSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float setirAmount = Input.GetAxis("Horizontal") * setirSpeed * Time.deltaTime;
        float accelerate = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -setirAmount);
        transform.Translate(0, accelerate, 0);
    }
}
