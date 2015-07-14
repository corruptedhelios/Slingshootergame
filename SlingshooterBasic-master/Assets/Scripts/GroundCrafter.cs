using UnityEngine;
using System.Collections;

public class GroundCrafter : MonoBehaviour {

	public int blockcount = 50;

	public GameObject groundPrefab;
	
	private GameObject[] groundInstances;
	
	void Awake() {
		
		groundInstances = new GameObject[blockcount];
		
		GameObject groundParent = GameObject.Find("GroundMaker");
		
		for(int i=0; i<blockcount; i++) {
			
			float divergence = Random.Range(9.73, 10.09);
			
			GameObject ground = Instantiate(groundPrefab);

			Vector3 cPos = Vector3.zero;

			cPos.x = -100 + (i*2.344);
			cPos.y = -1*divergence;
			
			ground.transform.position = cPos;
			
			ground.transform.parent = groundParent.transform;
			
			groundInstances[i] = ground;
		}
}

}
