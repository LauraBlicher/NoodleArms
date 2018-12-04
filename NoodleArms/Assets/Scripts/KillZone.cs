using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KillZone : MonoBehaviour {

	public Text countText;
	public int Topping;
	public Text loseText;
	public GameObject cam;
	private Vector3 camPos;
	private Quaternion camRot;

	public AudioClip[] audioClip;
	public AudioSource soundEffects;

	void Start()
	{
		SetCountText ();
		loseText.text = "";
		camPos = cam.transform.position;
		camRot = cam.transform.rotation;
	}


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Topping"))
		{
			other.gameObject.SetActive(false);
			Topping = Topping - 1;
			SetCountText ();
			//soundEffects.PlayOneShot (audioClip [0]);
			StartCoroutine (ScreenShake ());
			Debug.Log ("Shaketime");
		}
	}

	IEnumerator ScreenShake(){
		cam.GetComponent<Wiggle>().SendMessage("StartShake");
		Debug.Log ("Start CamShake");
		yield return new WaitForSeconds (2f);
		cam.GetComponent<Wiggle> ().SendMessage ("StopShake");
		Debug.Log ("Stop CamShake");
		cam.transform.position = camPos;
		cam.transform.rotation = camRot;
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


