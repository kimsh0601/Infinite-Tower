using UnityEngine;
using System.Collections;

public class ASManager : MonoBehaviour {
	public GameObject WeaponPop;
	public GameObject ArmorPop;
	public GameObject AccePop;
	public GameObject BtnPop;
	public GameObject WeaponButton;
	public GameObject ArmorButton;
	public GameObject AcceButton;
	public GameObject BackButton;
	public GameObject Otext;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	public void Back(){
		Application.LoadLevel("Town");
	}
	public void WeaponBtn(){
		WeaponPop.SetActive (true);
		BtnPop.SetActive (true);
		WeaponButton.SetActive (false);
		ArmorButton.SetActive (false);
		AcceButton.SetActive (false);
		BackButton.SetActive (false);
		Otext.SetActive (false);
	}
	public void ArmorBtn(){
		ArmorPop.SetActive (true);
		BtnPop.SetActive (true);
		WeaponButton.SetActive (false);
		ArmorButton.SetActive (false);
		AcceButton.SetActive (false);
		BackButton.SetActive (false);
		Otext.SetActive (false);
	}
	public void AcceBtn(){
		AccePop.SetActive (true);
		BtnPop.SetActive (true);
		WeaponButton.SetActive (false);
		ArmorButton.SetActive (false);
		AcceButton.SetActive (false);
		BackButton.SetActive (false);
		Otext.SetActive (false);
	}
	public void BackPopBtn(){
		WeaponPop.SetActive (false);
		ArmorPop.SetActive (false);
		AccePop.SetActive (false);
		WeaponButton.SetActive (true);
		ArmorButton.SetActive (true);
		AcceButton.SetActive (true);
		BackButton.SetActive (true);
		Otext.SetActive (true);
	}
}
