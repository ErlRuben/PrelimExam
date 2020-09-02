using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left12 : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Enemy1;
    public GameObject Enemy2;
    void OnTriggerEnter (Collider col) {
        if (col.gameObject.name == "Enemy")
        {
            Enemy.transform.forward = new Vector3(-3, 0, 1);
        }
        if (col.gameObject.name == "Enemy1")
        {
            Enemy1.transform.forward = new Vector3(-3, 0, 1);
        }
        if (col.gameObject.name == "Enemy2")
        {
            Enemy2.transform.forward = new Vector3(-3, 0, 1);
        }
        Debug.Log("hit");
        

        // Enemy.transform.Rotate(0.0f,1f,0.0f);
	}
}
