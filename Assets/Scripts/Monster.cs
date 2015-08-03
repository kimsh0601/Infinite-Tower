using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Monster : MonoBehaviour {
    public Transform target;
    public Vector3 direction;

    public Vector3 AutoMove;
    public float Auto_vel;

    public float velocity;
    public float M_spd;
    public float MTag;

    public float M_hp;
    public GameObject M_value;

    public Player Player;


   
	// Use this for initialization
	void Start () {
        
        M_value.GetComponent<Slider>().maxValue = M_hp;
        M_value.GetComponent<Slider>().value = M_hp;
        RandomMove();
        Auto_vel = 0.01f;

        


    }
    void RandomMove() {
        AutoMove.x = Random.Range(-10.0f, 10.0f);
        AutoMove.y = Random.Range(-10.0f, 10.0f);
        Invoke("RandomMove", 1.5f);
    }

	
	// Update is called once per frame
	void Update () {

        target = GameObject.Find("PlayerEX").transform;
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= MTag)
        {
            //CancelInvoke();
            MoveTarget();
            AutoMove = direction;
        }
        else
        {
            velocity = 0.0f;
            this.transform.position = new Vector3(transform.position.x + (AutoMove.x * Auto_vel * Time.deltaTime),
                                                   transform.position.y + (AutoMove.y * Auto_vel * Time.deltaTime),
                                                   transform.position.z);
        }
        
        


    }
   
    void MoveTarget()
    {       
        //플레이어의 위치와 몬스터의 위치를 빼고 단위 백터화
        direction = (target.position - transform.position).normalized;
        
        //초가 아닌 한 프레임으로 속도증가
        velocity = (M_spd * Time.deltaTime);
               
        // 해당 방향으로 무우-빙
        this.transform.position = new Vector3(transform.position.x + (direction.x * velocity),
                                                   transform.position.y + (direction.y * velocity),
                                                   transform.position.z);
        
      
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "WPTag") {
            M_hp -= Player.P_dmg;
        M_value.GetComponent<Slider>().value = M_hp;
            if (M_hp <= 0) {
                Destroy(M_value);
                Destroy(gameObject);

                
                

                    
            }

      }
    }
   

}
