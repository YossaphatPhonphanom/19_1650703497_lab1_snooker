using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    { 
        Ball b = other.gameObject.GetComponent<Ball>();

        if (b != null)
        {
            GameManager.instance.Playerscore += b.Point;
            GameManager.instance.UpdateScoreText();
            Destroy(b.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
