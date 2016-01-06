using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

	private Vector3 handPos;

	private Vector3 startPos;
	private Vector3 movedPos;

	public float sensitivity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButton(0)) {
//			float normalizedHandPos = gameObject.transform.position.x;
//			float mousePos = (Input.mousePosition.x / Screen.width - 0.5f) * 20;
//			float xPos = gameObject.transform.position.x + (mousePos - normalizedHandPos) * 0.25f;
//			handPos = new Vector3 (Mathf.Clamp(xPos,-8,10), -15, 0);
//			gameObject.transform.position = handPos;
//		}

		if (Input.GetMouseButton(0)) {
			if (Input.GetMouseButtonDown (0)) {
				startPos = Input.mousePosition;
			} else {
				Debug.Log (startPos);
				Debug.Log (Input.mousePosition);
				movedPos = Input.mousePosition;
				float deltaX = (startPos.x - movedPos.x) * sensitivity;
				handPos = new Vector3 (Mathf.Clamp (gameObject.transform.position.x - deltaX, -8, 10), gameObject.transform.position.y, gameObject.transform.position.z);
				gameObject.transform.position = handPos;
				startPos = movedPos;
			}

//			switch (touch.phase) {
//
//			case TouchPhase.Began:
//				startPos = touch.position;
//				break;
//
//			case TouchPhase.Moved:
//				movedPos = touch.position;
//				float xPos = startPos.x - (startPos.x - movedPos.x) * sensitivity;
//				handPos = new Vector3 (Mathf.Clamp (xPos, -8, 10), gameObject.transform.position.y, gameObject.transform.position.z);
//				gameObject.transform.position = handPos;
//				startPos = movedPos;
//				break;
//
//			}
		}

	}
}
