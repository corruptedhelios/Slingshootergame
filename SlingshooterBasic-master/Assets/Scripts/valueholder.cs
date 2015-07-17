using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class valueholder : MonoBehaviour {

		public int value;
		Text Yourscore;

		void Awake(){
			DontDestroyOnLoad (transform.gameObject);
		}
		
		void Update () {
		if (GameObject.Find ("Projectile(Clone)")) {
			value = GameObject.Find ("Projectile(Clone)").GetComponent<Projectile> ().score;
		}
		if (GameObject.Find ("Text")) {
			Yourscore = GameObject.Find ("Text").GetComponent<Text> ();
			Yourscore.text = "Your score: " + value;
		}
		}
	}

