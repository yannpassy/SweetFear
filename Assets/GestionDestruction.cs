using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionDestruction : MonoBehaviour {
    public float[] dur = new float[10];
    public GameObject[] mesGameObject = new GameObject[10];
    public float chrono;
	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    void Update() {
        float chronoOld = chrono;
        chrono += Time.deltaTime;

        if (chronoOld < dur[0] && chrono >= dur[0])
        {
            mesGameObject[0].GetComponent<ActiveTrueFalse>().enabled = true;
        }
        if (chronoOld < dur[1] && chrono >= dur[1])
        {
            mesGameObject[1].GetComponent<ActiveTrueFalse>().enabled = true;
        }
    }
}
