using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {

    public string activeTag;

    bool fallIn;

    public bool IsFallin()
    {
        return fallIn;
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == activeTag)
        {
            fallIn = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag==activeTag)
        {
            fallIn = false;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        Vector3 direction = transform.position - other.gameObject.transform.position;
        direction.Normalize();

        if(other.gameObject.tag == activeTag)
        {
            r.velocity *= 0.9f;

            r.AddForce(direction * r.mass * 20.0f);
        }
        else
        {
            r.AddForce(-direction * r.mass * 80.0f);
        }
    }
}
