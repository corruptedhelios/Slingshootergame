using UnityEngine;
using System.Collections;

public class PickupCrafter : MonoBehaviour {
	
	public int numPickups = 40;
	
	public Vector3 pickupPosMin;
	public Vector3 pickupPosMax;
	
	public GameObject pickupPrefab;
	
	private GameObject[] pickupInstances;
	
	void Awake() {
		
		pickupInstances = new GameObject[numPickups];
		
		GameObject pickupParent = GameObject.Find("PickupMaker");
		
		for(int i=0; i<numPickups; i++) {
			
			GameObject pickup = Instantiate(pickupPrefab);
			
			Vector3 cPos = Vector3.zero;
			
			cPos.x = Random.Range(pickupPosMin.x, pickupPosMax.x);
			cPos.y = Random.Range(pickupPosMin.y, pickupPosMax.y);
			
			pickup.transform.position = cPos;
			
			pickup.transform.parent = pickupParent.transform;
			
			pickupInstances[i] = pickup;
		}
	}
}
