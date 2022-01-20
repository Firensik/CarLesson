using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarMovment : MonoBehaviour
{
    public float carHorizontalSpeed = 2f;
    private Vector3 carPosition;


    void Start()
    {
        carPosition = this.gameObject.transform.position;
    }

    void Update()
    {
        carPosition.x += Input.GetAxis("Horizontal") * carHorizontalSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp(carPosition.x, -3.98f, 3.98f);
        this.gameObject.transform.position = carPosition;
    }
}
