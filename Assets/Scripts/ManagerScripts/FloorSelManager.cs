using UnityEngine;
using System.Collections;

public class FloorSelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Town(){
		Application.LoadLevel("Town");
	}
	public void FirstFloor(){
		Application.LoadLevel("GamePlay");
	}
}
