using UnityEngine;
using System.Collections;

public class RandomWalker : MonoBehaviour {
  public const float DISTANCE = 0.05f;

  void Update() {
    var x = gameObject.transform.position.x;
    var y = gameObject.transform.position.y;
    var newX = x + Random.Range(-DISTANCE, DISTANCE);
    var newY = y + Random.Range(-DISTANCE, DISTANCE);

    gameObject.transform.position = new Vector3(newX, newY, gameObject.transform.position.z);
  }
}
