using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DGManager : MonoBehaviour {
    public List<GameObject> mList = new List<GameObject>();
    public GameObject[] Monster;

    public Player Player;
    public GameObject _dead;

    public Animator anim;
	
    void Awake()
    {
        
        Monster = GameObject.FindGameObjectsWithTag("MOB");
        foreach (GameObject enemy in Monster)
            mList.Add(enemy);
    
    }
	// Use this for initialization
	void Start () {
       
        
	}
	
	// Update is called once per frame
	void Update () {
        
       if (mList.Count <= 0) {
			//Application.LoadLevel("FloorSelect");
		}
        if (Player.P_hp <= 0)
         {
            Time.timeScale = 0;
            _dead.SetActive(true);
            anim.SetBool("DEAD", true);
         }
    }
}
