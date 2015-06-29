using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public static FollowCam S;

	public GameObject poi;

	private float camZ;

	void Awake() {
		S = this;
		camZ = this.transform.position.z;
	}

	void Update() {
		if(poi == null) {
			return;
		}

		Vector3 destination = poi.transform.position;

		// if higher than 0 max is dest.y if lower than 0 max is 0
		destination.x = Mathf.Max (0, destination.x);
		destination.y = Mathf.Max (0, destination.y);

		destination.z = camZ;
		transform.position = destination;
	
		this.GetComponent<Camera>().orthographicSize = 10 + destination.y;
	
	}




}
