using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject keyPoofPrefab;
	public Door door;
	public float rotateSpeed = 200f;
	//public AudioSource clip;
	public AudioClip keyAudioClip;
	public static bool destroy;


	private void Start()
	{
	
		destroy = false;
	}

	void Update()
	{
		//Code used for the rotation animation of the key
			transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

	
	}

	public void OnKeyClicked()
	{
		//destroy = true;

		keyPoofPrefab.GetComponent<AudioSource>().clip = keyAudioClip;
		//Code used to initate the collection of the object i.e. the key
		Instantiate(keyPoofPrefab, transform.position, Quaternion.identity);

		//keyChime.Play();


		//Code used instantiate the poof animation once the key is clicked
		door.Unlock();

		Destroy(gameObject);
	}


}