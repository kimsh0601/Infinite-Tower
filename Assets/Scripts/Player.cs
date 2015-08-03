using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

    public class Player : MonoBehaviour {

    bool facingRight = true; // 캐릭터의 방향 전환을 위한 불값
    Vector3 movement; // 상하좌우 움직임을 위한 벡터

    public float P_dmg; // 플레이어 데미지
    public float P_mspd; // 플레이어 스피드

    

    Animator anim;
 
	// Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
       
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
}
