using UnityEngine;
using System.Collections;

public class PickupGreen : MonoBehaviour {

	public void OnTriggerEnter(Collider col){

		GameObject collidedWith = col.gameObject;
		if(collidedWith.name.Contains("Projectile")){
			Destroy (this.gameObject);
			Vector3 boost = new Vector3(Random.Range(0.8f,1.2f),1,0);
			collidedWith.GetComponent<Rigidbody>().velocity = boost * 20;
		}
}
}
