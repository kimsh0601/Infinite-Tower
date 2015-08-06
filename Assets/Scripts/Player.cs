using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

    public class Player : MonoBehaviour {

    bool facingRight = true; // 캐릭터의 방향 전환을 위한 불값
    Vector3 movement; // 상하좌우 움직임을 위한 벡터

    public float P_hp; // 플레이어의 체력
    public float P_dmg; // 플레이어 데미지
    public float P_mspd; // 플레이어 스피드
    public int P_gold;

    public Text Fanta;

    
    public GameObject P_value;


    

    Animator anim;
 
	// Use this for initialization
    void Awake()
    {
        //PlayerPrefs.Save();
        

        P_hp = 200.0f;
        anim = GetComponent<Animator>();

        if (P_value != null){
            P_value.GetComponent<Slider>().maxValue = P_hp;
            P_value.GetComponent<Slider>().value = P_hp;
        }
    }
	void Start () {
        
	    
	}
    void Flip(){
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
	// Update is called once per frame
	void Update () {

        

	}
    void FixedUpdate()
    {
        //PlayerPrefs.SetInt("P_Gold", P_gold);
        Move();

    }
    void Move()
    {
        float h = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        float v = CrossPlatformInputManager.GetAxisRaw("Vertical");
        movement.Set(h, v, 0);
        if (h > 0 && !facingRight || h < 0 && facingRight) Flip();

        if (h > 0 || h < 0 || v < 0 || v > 0) {
            anim.SetBool("IsWalk", true);
        }
        else {
           anim.SetBool("IsWalk", false);
        }
        
        transform.Translate(movement * P_mspd * Time.deltaTime);

    }
  

    void OnTriggerEnter2D(Collider2D col)
    {    
		if (col.transform.tag == "TowerTag") {
			Application.LoadLevel("FloorSelect");
		}
		if (col.transform.tag == "ForgeTag") {
			Application.LoadLevel("Forge");
		}
        
    }
}
