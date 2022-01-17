using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    Score score;
    Boll ball;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        ball = FindObjectOfType<Boll>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball.Reset();
        if (gameObject.name == "Goal 1")
        {
            score.p2s += 1;

        }
        if (gameObject.name == "Goal 2")
        {
            score.p1s += 1;

        }

        print("mål");
    }
}
