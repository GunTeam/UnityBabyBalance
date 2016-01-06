using UnityEngine;
using System.Collections;

public class Baby : MonoBehaviour {

	private Sprite[] babySprites;
	private SpriteRenderer baby;

	void Start () {
		baby = gameObject.GetComponent<SpriteRenderer> ();
		babySprites = Resources.LoadAll<Sprite> ("Art/Babies");
	}
	
	// Update is called once per frame
	void Update () {
		HingeJoint2D hinge = gameObject.GetComponent<HingeJoint2D>();
		if (hinge.enabled) {
			if (Mathf.Abs (hinge.jointAngle) < 10) {
				baby.sprite = babySprites [0];
			} else if (Mathf.Abs (hinge.jointAngle) < 20) {
				baby.sprite = babySprites [1];
			} else if (Mathf.Abs (hinge.jointAngle) < 45) {
				baby.sprite = babySprites [2];
			} else {
				hinge.enabled = false;
				hinge.enableCollision = true;
				gameOver ();
			}
		}
	}

	public void startGame(){
		Debug.Log ("Starting game");
	}

	public void gameOver(){
		Application.LoadLevel (Application.loadedLevel);
	}
}
