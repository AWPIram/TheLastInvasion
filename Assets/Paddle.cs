using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
            print("ex");
        }

        if (Input.GetKey(down))
        {
            transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
            print("ex");
        }
    }
}
