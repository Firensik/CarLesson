using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilCarBehavior : MonoBehaviour
{

    public float civilCarSpeed = 5f;
    public int direction = -1;

    private Vector3 civilCarPosition;

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(0, direction, 0) * civilCarSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Debug.Log("Gracz w nas wjecha³");
            Destroy(this.gameObject);
        }
        else if (obj.gameObject.tag == "EndOfTheRoad")
        {
            Destroy(this.gameObject);
        }
    }

}