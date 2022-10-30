using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public static CameraFollow instance;
    public GameObject Ball;
    Vector3 offset;
    public float lerpRate;
    public bool gameOver;

   void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

                
    }


	// Use this for initialization
	void Start () {
        offset = Ball.transform.position - transform.position;
        gameOver = false;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!gameOver)
        {
            Follow();
        }
		
	}

    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetpos = Ball.transform.position - offset;
        pos = Vector3.Lerp(pos, targetpos, lerpRate * Time.deltaTime);
        transform.position = pos;

    }

    public void DestroyBall()
    {
        Destroy(Ball,0.5f);

    }

        
}
