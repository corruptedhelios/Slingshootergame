using UnityEngine;
using System.Collections;

public class valueholder : MonoBehaviour {

		public int value;
		
		void Awake(){
			DontDestroyOnLoad (transform.gameObject);
		}
		
		void Update () {
			value = GameObject.Find ("Projectile").GetComponent<Projectile>().score;

		}
	}

