using UnityEngine;
using System.Collections;

public class DGManager : MonoBehaviour {
    public ArrayList List;
	
	// Use this for initialization
	void Start () {
        List = GetComponent <ArrayList>();

        List.Add(GameObject.FindWithTag("MOB"));
	}
	
	// Update is called once per frame
	void Update () {
       if (List == null) {
			Application.LoadLevel("FloorSelect");
		}
    }
}
