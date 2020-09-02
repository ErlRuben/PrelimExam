using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Finishcollider : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Player;
    
    void OnTriggerEnter (Collider col) {
        Debug.Log("On");
        if (col.gameObject.name == "Enemy")
        {
            Destroy (Enemy);
            SceneManager.LoadScene("LoseGame");
        }
        if (col.gameObject.name == "Enemy1")
        {
            Destroy (Enemy1);
            SceneManager.LoadScene("LoseGame");
        }
        if (col.gameObject.name == "Enemy2")
        {
            Destroy(Enemy2);
            SceneManager.LoadScene("LoseGame");
        }
        if (col.gameObject.name == "Player")
        {
            Destroy(Player);
            SceneManager.LoadScene("Wingame");
        }
      
        // Enemy.transform.Translate(0,0,0);
        // Enemy.transform.position =  Enemy.transform.position + Enemy.transform.forward * speed;
        
        // Enemy.transform.Rotate(0.0f,1f,0.0f);
	}
}
