using UnityEngine;
using System.Collections;

public class Skill : MonoBehaviour {


    private Animator Anim;
    
    // Use this for initialization
    void Awake() {
        Anim = GetComponent<Animator>();
    }
    void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    public void Atk()
    {
        Anim.Play("PlayerAtk");
    }
}
