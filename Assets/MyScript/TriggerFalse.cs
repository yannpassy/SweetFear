using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFalse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision col) {
        col.gameObject.GetComponent<MeshCollider>().isTrigger = true;
        Debug.Log("la collision est avec :" + gameObject.name);
     
	}
}
