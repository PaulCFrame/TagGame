using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeardScript : MonoBehaviour {

    public float maxScale;
    public float minScale;
    public float addition;
    public GameObject parent;

    bool beardExtendo;

	// Use this for initialization
	void Start ()
    {
        minScale = transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            beardExtendo = true;
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            beardExtendo = false;
        }
        
        transform.position = parent.transform.position;

        if (beardExtendo)
        {
            if (transform.localScale.z < maxScale)
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + Time.deltaTime * addition);
                transform.position = parent.transform.position + transform.localScale.z / 2 * -parent.transform.forward;
            }
            else
            {
                transform.position = parent.transform.position + transform.localScale.z / 2 * -parent.transform.forward;
            }
        }

        if (!beardExtendo && transform.localScale.z > minScale)
        {
            transform.localScale = new Vector3(transform.localScale.x , transform.localScale.y, transform.localScale.z - Time.deltaTime * addition);
            transform.position = parent.transform.position + transform.localScale.z / 2 * -parent.transform.forward;
        }
    }
}
