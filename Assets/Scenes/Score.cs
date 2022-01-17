using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int p1s;
    public int p2s;

    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = p1s + "-" + p2s;
    }
}
