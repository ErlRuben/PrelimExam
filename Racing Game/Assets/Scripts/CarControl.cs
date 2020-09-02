using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    float speed = 2;
	float gravity = 10;

    float rotSpeed = 40;
	float rot = 2f;

	Vector3 moveDir = Vector3.zero;

	CharacterController controller;

	void Start () 
	{
		controller = GetComponent<CharacterController> ();
	}

	void Update ()
	{
		
		Movement ();
	}

	void Movement()
	{
		if (controller.isGrounded) 
		{
			
			Times();
		
            if (Input.GetKey (KeyCode.S)) 
			{
                moveDir = new Vector3 (0, 0, -6); 
                moveDir *= speed;
                moveDir = transform.TransformDirection (moveDir);
			}
        
			if (Input.GetKeyUp (KeyCode.A)) 
			{
				transform.Rotate(0,-1,-12); 

			}
        	if (Input.GetKeyDown (KeyCode.A)) 
			{
				transform.Rotate(0,0,0); 

			}
			if (Input.GetKeyUp (KeyCode.D)) 
			{
				transform.Rotate(0,1,12); 

			}
        	if (Input.GetKeyDown (KeyCode.D)) 
			{
				transform.Rotate(0,0,0); 

			}
            if (Input.GetKey (KeyCode.LeftShift)) 
			{ 
                moveDir = new Vector3 (0, 0, 35);
                moveDir *= speed;
                moveDir = transform.TransformDirection (moveDir);  
			}
            if (Input.GetKeyDown (KeyCode.Space)) 
			{ 
				moveDir = new Vector3 (0, 0, 12);
                moveDir *= speed;
                moveDir = transform.TransformDirection (moveDir);  
			}
			if (Input.GetKeyUp (KeyCode.Space)) 
			{ 
				Stop();
			}
           
       
		}
        
        rot = rot + Input.GetAxis ("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3 (0, rot, 0);
        
        moveDir.y = moveDir.y - gravity * Time.deltaTime;
		controller.Move (moveDir * Time.deltaTime);
        
	}
    void Stop()
	{
		StartCoroutine (Slowstop());
        
	}
	IEnumerator Slowstop()
	{
		moveDir = new Vector3 (0, 0, 11);
		moveDir *= speed;
		moveDir = transform.TransformDirection (moveDir);  
		yield return new WaitForSeconds (1);
		moveDir = new Vector3 (0, 0, 6);
		moveDir *= speed;
		moveDir = transform.TransformDirection (moveDir);  
		yield return new WaitForSeconds (1);
		moveDir = new Vector3 (0, 0, 0);
		moveDir *= speed;
		moveDir = transform.TransformDirection (moveDir);  
		
	}
	void Times()
	{
		StartCoroutine (Timer());
	}
	IEnumerator Timer()
	{
		moveDir = new Vector3 (0, 0, 0); 
		moveDir *= speed;
		moveDir = transform.TransformDirection (moveDir);
		yield return new WaitForSeconds (3);
		moveDir = new Vector3 (0, 0, 30); 
		moveDir *= speed;
		moveDir = transform.TransformDirection (moveDir);
	}
	
    
}
