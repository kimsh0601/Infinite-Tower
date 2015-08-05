using UnityEngine;
using System.Collections;

public class DGManager : MonoBehaviour {


    public int Counting;
    public int MAX;
	// Use this for initialization
	void Start () {
        Counting = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
      if(Counting == MAX)
        {
            Application.LoadLevel("FloorSelect");
        }
    }
   
}
