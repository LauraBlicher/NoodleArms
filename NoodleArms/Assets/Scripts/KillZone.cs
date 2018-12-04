using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KillZone : MonoBehaviour {

	public Text countText;
	public int Topping;
	public Text loseText;

	public AudioClip[] audioClip;
	public AudioSource soundEffects;

	void Start()
	{
		SetCountText ();
		loseText.text = "";
	}


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Topping"))
		{
			other.gameObject.SetActive(false);
			Topping = Topping - 1;
			SetCountText ();
		soundEffects.PlayOneShot (audioClip [0]);
		}
	}

	public int GetCount()
	{
		return Topping;
	}
	void SetCountText()
	{
		countText.text = "Toppings " + Topping.ToString ();
		if (Topping <= 0) 
		{
			loseText.text = "You Lose!";
		}
	}

}


