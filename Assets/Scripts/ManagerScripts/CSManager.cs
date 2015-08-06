using UnityEngine;
using System.Collections;

public class CSManager : MonoBehaviour {
	private Animator Anim;
	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void Left(){
		Anim.SetInteger ("ClassInt",1);
	}
	public void Right(){
		Anim.SetInteger ("ClassInt", 2);
	}
}
//클래스 인트부분에 문제가 있어보임 ㅇㅇ 애니메이션이 동시에 실행됨.
