using UnityEngine;
using System.Collections;

public class PickupRed : MonoBehaviour {

	private ParticleSystem Explosion;
	//private GameObject gameObject;

	void Start(){
			Explosion= GameObject.Find ("EXPLOSION").GetComponent<ParticleSystem>();
	} 


	float delta=0;
	bool exploding=false;
	void Update() {
		if (exploding) {
			delta += Time.deltaTime;
			if (delta >= 0.1f) {
				Explosion.Stop();
				Destroy (this.gameObject);
				exploding=false;
			}
		}
	}


	public void OnTriggerEnter(Collider col){
		
		GameObject collidedWith = col.gameObject;
		if(collidedWith.name.Contains("Projectile")){

			Destroy (col.gameObject);
			Vector3 expos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
				Explosion.gameObject.transform.position = expos;
			Explosion.gameObject.SetActive(true);
			exploding=true;
		}
	}
}
