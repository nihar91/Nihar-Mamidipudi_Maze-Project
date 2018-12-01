using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour
{	
        
		public Door door;
		public int numCoins=9;
		static int coins=0;
		static float perception=0;
		static bool displayText=false;
		Text message;


		public void start()
		{
		// Code used to enable the number of coins collected
		coins = 0;
		perception = 0;
		displayText = false;
		
		}

	public void  Update()
	{
		//Code shows the number of coins collected

		if (displayText == true) {
			message = GetComponent<Text> ();
			message.text = "Coins Collected :" + coins + " Out of " + numCoins + "\n Score:" + perception + "\n\n Play again?";
		}
			
	}

	public void addCoin()
	{
		//Code shows the number of coins collected at the end of the game
		coins++;
		float coinsFloat = coins * 1.0f;
		float numCoinsFloat = numCoins * 1.0f;
		perception = Mathf.Round(coinsFloat / numCoinsFloat * 20.0f);

	}

	public void ResetScene()
	{
		door.ResetVariables();
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}

	public void drawText()
	{
	//Code used to reset the scene
		displayText = true;
	}
		
}
