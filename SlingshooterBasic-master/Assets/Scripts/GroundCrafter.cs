using UnityEngine;
using System.Collections;

public class GroundCrafter : MonoBehaviour {

	public int blockcount = 200;

	public GameObject groundPrefab;
	
	private GameObject[] groundInstances;
	
	void Awake() {
		
		groundInstances = new GameObject[blockcount];
		
		GameObject groundParent = GameObject.Find("GroundMaker");
		
		for(int i=0; i<blockcount; i++) {

			float number = (float)i;

			GameObject ground = Instantiate(groundPrefab);

			Vector3 cPos = Vector3.zero;

			cPos.x = (float)(-100 + (number*2.344));
			cPos.y = -1*(Random.Range(9.73f, 10.09f));
			
			ground.transform.position = cPos;
			
			ground.transform.parent = groundParent.transform;
			
			groundInstances[i] = ground;
		}
}

}
