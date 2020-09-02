using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirightControl : MonoBehaviour
{
    public GameObject Enemy;
    void OnTriggerEnter (Collider col) {
        Debug.Log("hit");

       
        Enemy.transform.position = new Vector3(0,0,1);
	}

}
