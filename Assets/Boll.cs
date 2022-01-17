using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boll : MonoBehaviour
{


    Vector3 direction = new Vector3(1, 0, 0);
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Clamp(speed, -6, 6);
        transform.position += speed *direction * Time.deltaTime;
    }

    public void Reset()
    {
        speed = 5;
        transform.position = new Vector3(0, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        direction.y = Random.Range(-1, 2);

        if (collision.gameObject.tag == "Player")
        {
            speed += 0.25f;

            direction.x = -direction.x;
        }
        if (transform.position.y < collision.transform.position.y)
        {
            direction.y = -1;
        }
        else
        {
            direction.y = 1;
        }

        print("träff");
    }
}
