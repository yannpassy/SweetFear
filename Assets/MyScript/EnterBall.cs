using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBall : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionStay(Collision col)
    {
            col.gameObject.GetComponent<MeshCollider>().isTrigger = true;
            Debug.Log("la collision est avec l'objet :" + gameObject.name); 
    }
}
