using UnityEngine;
using System.Collections;

public class PartierSpawner : MonoBehaviour {
  	public GameObject PartierPrefab;
  	public int Count;

	void Start() {
    	
    	for (int i = 0; i < Count; i++) {
	      	GameObject.Instantiate(PartierPrefab, new Vector3(i, i, -1), Quaternion.identity);
    	}
	}
}
