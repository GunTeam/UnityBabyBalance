using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

	public Vector3 handPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			float normalizedHandPos = gameObject.transform.position.x;
			float mousePos = (Input.mousePosition.x / Screen.width - 0.5f) * 20;
			float xPos = gameObject.transform.position.x + (mousePos - normalizedHandPos);
			handPos = new Vector3 (Mathf.Clamp(xPos,-8,10), -15, 0);
			gameObject.transform.position = handPos;
		}
	}
}
