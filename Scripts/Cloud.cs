using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

    public float horizontalSpeed;
    public Transform LeftSpawn;
    public Transform RightSpawn;

    private Transform trans;

	// Use this for initialization
	void Start () {
        trans = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        trans.position = new Vector3(trans.position.x + horizontalSpeed * Time.deltaTime, trans.position.y, trans.position.z);
	}


}
