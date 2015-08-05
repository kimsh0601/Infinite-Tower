using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloorSelManager : MonoBehaviour {

    public int playerG;
    public Text goldT;
	// Use this for initialization
	void Start () {
        playerG = PlayerPrefs.GetInt("P_GOLD");
        Debug.Log(playerG);

        
	
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
    public void Two()
    {
        Application.LoadLevel("2");
    }
    public void Three()
    {
        Application.LoadLevel("3");
    }
    public void Four()
    {

    }
    public void Five()
    {
        Application.LoadLevel("5");
    }
}
