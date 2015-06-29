using UnityEngine;
using System.Collections;

public class CloudCrafter : MonoBehaviour {

	public int numClouds = 40;

	public Vector3 cloudPosMin;
	public Vector3 cloudPosMax;

	public GameObject[] cloudPrefabs;

	private GameObject[] cloudInstances;

	void Awake() {

		cloudInstances = new GameObject[numClouds];

		GameObject cloudParent = GameObject.Find("CloudMaker");

		for(int i=0; i<numClouds; i++) {
	
			int chosenPrefab = Random.Range(0, cloudPrefabs.Length);

			GameObject cloud = Instantiate(cloudPrefabs [chosenPrefab]);

			Vector3 cPos = Vector3.zero;

			cPos.x = Random.Range(cloudPosMin.x, cloudPosMax.x);
			cPos.y = Random.Range(cloudPosMin.y, cloudPosMax.y);

			cloud.transform.position = cPos;

			cloud.transform.parent = cloudParent.transform;
		
			cloudInstances[i] = cloud;
		}
	}
}
