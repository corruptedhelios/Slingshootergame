using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Projectile : MonoBehaviour {

	public bool done = false;
	public int score;
	public int i = 0;
	public int e = 0;
	int oldscore;
	Text text1;
	
	ParticleSystem particles;

	bool stopped=false;

	// Use this for initialization
	void Start () {
		particles = GameObject.Find("ParticleSystemProjectile").GetComponent<ParticleSystem>();
		text1 = GameObject.Find ("Text").GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		score = 9 + (int)gameObject.transform.position.x;
		text1.text = "Distance: " + score;
		Vector3 Trans = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
		particles.transform.position = Trans;
		if (gameObject.transform.position.x > 2) {
			i++;
		}
		if (score != oldscore) {
			i = 0;
		}
		if (i == 100) {
			done = true;
		}
			oldscore= 9 + (int)gameObject.transform.position.x;
		if (done) {
			e++;
		}
		if (e>30){
			Application.LoadLevel(0);
		}
	}

	void OnDestroy(){
		particles.Stop();
		Application.LoadLevel(0);
	}
}
