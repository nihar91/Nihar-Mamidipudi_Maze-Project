using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject coinPoofPrefab;
	public SignPost signPost;
public float rotateSpeed = 200f;
	//public AudioSource CoinFound;
	public AudioClip CoinFound;


	void Update()
	{
		//Code used to initate the rotation animation of the coin

		transform.Rotate (Vector3.up, rotateSpeed * Time.deltaTime);

	}


	public void OnCoinClicked () 
	{
		signPost.addCoin();

		coinPoofPrefab.GetComponent<AudioSource>().clip = CoinFound;

		Vector3 coinPos = transform.position;
		//Code used to enable the collectable function of the coin
		Instantiate(coinPoofPrefab, coinPos, Quaternion.identity);



		//Code used to enable the poof animation once the coin is collected
		Destroy(transform.gameObject);


    }
}