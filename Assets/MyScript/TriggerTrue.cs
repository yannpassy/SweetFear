using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrue : MonoBehaviour {
    public GameObject sphere;
    private double chrono;
	// Use this for initialization
	void Start () {
		
	}
    void Update()
    {
        chrono += Time.deltaTime;
        if (chrono > 0.3)
        {
            sphere.transform.position = this.gameObject.transform.GetChild(0).gameObject.transform.position;
            //nombreEnfant++;
            chrono = 0;
        }
    }
}
