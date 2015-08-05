using UnityEngine;
using System.Collections;

public class DGManager : MonoBehaviour {
	public GameObject Mob;
	
	// Use this for initialization
	void Start () {
		Mob = GameObject.FindWithTag("MOB");
	}
	
	// Update is called once per frame
	void Update () {
       if (Mob == null) {
			Application.LoadLevel("FloorSelect");
		}
    }
}
