using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public static bool keyFound = false;
	public static bool doorClicked = false;
	public float Speed = 0.5f;
	public AudioSource audioSource;
	//public AudioSource doorLocked;
	public AudioClip clip1;
	public AudioClip clip2;
	public SignPost signPost;

	public void Unlock()
	{
	
		keyFound = true;
	
	}
	public void OnDoorClicked()

	{
		//Code used to keep the door locked without collecting the key
		if (keyFound == true) {

			doorClicked = true;
			audioSource.clip = clip1;
			audioSource.Play();
		} 
		else 
		{
			audioSource.clip = clip2;
			audioSource.Play();
		}
	}

	public void Update()
	{
		//Code used to unlock the door once the key is collected 
		if (keyFound == true && doorClicked == true) {
			Vector3 endPosition = new Vector3 (transform.position.x, 9.0f, transform.position.z);
			transform.position = Vector3.Lerp (transform.position, endPosition, Speed * Time.deltaTime);
			signPost.drawText ();
		}
	}
		
	public void ResetVariables()
		{
			keyFound=false;
			doorClicked=false;

		
		}
	
	

}