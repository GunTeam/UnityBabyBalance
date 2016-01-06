using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {
	public Baby baby;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			baby.startGame ();
			Destroy (gameObject);
		}
	}
}
