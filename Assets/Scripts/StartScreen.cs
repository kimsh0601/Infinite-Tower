using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

    private int Tutorial;

    // Use this for initialization
    void Awake () {
        Tutorial = PlayerPrefs.GetInt("char");
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
            if (Tutorial == 0) Application.LoadLevel("CharacterSelect");
            else Application.LoadLevel("Town");
		}
	}
}
