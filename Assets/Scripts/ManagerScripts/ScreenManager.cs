using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {
    
    void Awake() {
        DontDestroyOnLoad(this);

        Screen.SetResolution(Screen.width, (Screen.width / 16) * 9, true);
        
    }
    // Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
