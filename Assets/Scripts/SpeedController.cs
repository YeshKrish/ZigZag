using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour {

    public GameObject Ball;
    float currentspeed = 0f;
    float maxspeed = 10f;
    private float screenCenterX;
    public float acceralationtime = 60;
    private float minspeed;
    private float time;
 
    

	// Use this for initialization
	void Start () {
        screenCenterX = Screen.width * 0.5f;
        minspeed = currentspeed;
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentspeed = Mathf.SmoothStep(minspeed, maxspeed, time / acceralationtime);
        transform.position = transform.forward * currentspeed * Time.deltaTime;
        time += Time.deltaTime; 
	}
}
