using UnityEngine;
using System.Collections;

public class PartierSpawner : MonoBehaviour {
  	public GameObject PartierPrefab;
  	public int Count;
  	public float XMin;
  	public float XMax;
  	public float YMin;
  	public float YMax;

	void Start() {
    	for (int i = 0; i < Count; i++) {
	      	GameObject.Instantiate(PartierPrefab, new Vector3(Random.Range(XMin, XMax), Random.Range(YMin, YMax), -1), Quaternion.identity);
    	}
	}
}
