using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class M_HPBar : MonoBehaviour {

    public Transform target;
    public Vector2 Mytar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 Mytar = new Vector2(target.position.x +0.1f ,target.position.y +0.3f);

        Vector2 wantedPos = Camera.main.WorldToScreenPoint(Mytar);
        transform.position = wantedPos;

        
	
	}
}
