using UnityEngine;
using System.Collections;

public class TownManager : MonoBehaviour {

	private Collider2D Forge;
	private Collider2D Tower;
	// Use this for initialization
	void Awake(){
		Forge = GameObject.Find ("Forge").GetComponent<Collider2D> ();
		Tower = GameObject.Find ("Tower").GetComponent<Collider2D> ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Forge.transform.name == "PlayerEX") {
			Application.LoadLevel("Forge");
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (Forge.transform.name == "PlayerEX") {
			Application.LoadLevel("Forge");
		}
		if (Tower.transform.name == "PlayerEX") {
			Application.LoadLevel("Tower");
		}
	}
}
