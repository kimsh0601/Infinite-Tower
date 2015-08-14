using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    private DGManager DG;
    public Transform target;
      
    public Vector3 direction;
    public Vector3 AutoMove;

    public float Auto_vel;
    public float velocity;
    public float M_spd;
    public float MTag;

    public int M_gold;

    public float M_dmg;
    public float M_hp;

    public GameObject M_value;
    
    public Player Player;
    

    public int min;
    public int max;



    // Use this for initialization
    void Start()
    {
        DG = GameObject.Find("Main Camera").GetComponent<DGManager>();
        
        M_gold = Random.Range(min, max);
        M_value.GetComponent<Slider>().maxValue = M_hp;
        M_value.GetComponent<Slider>().value = M_hp;
        RandomMove();
        Auto_vel = 0.1f;

        M_dmg = 10.0f;




    }
    void RandomMove()
    {
        AutoMove.x = Random.Range(-10.0f, 10.0f);
        AutoMove.y = Random.Range(-10.0f, 10.0f);
        Invoke("RandomMove", 1.5f);
    }


    // Update is called once per frame
    void Update()
    {

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
                                                   transform.position.y  + (direction.y * velocity),
                                                   transform.position.z);


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "WPTag")
        {
            M_hp -= Player.P_dmg;

            M_value.GetComponent<Slider>().value = M_hp;
            if (gameObject.transform.position.x > target.position.x)
            {
                transform.Translate(0.2f,0f,0f);
            }
            else { transform.Translate(-0.2f, 0f, 0f); }
            if (M_hp <= 0)
            {
                Player.P_gold += M_gold;
                DG.mList.Remove(gameObject);
                Debug.Log(M_gold);
                Destroy(M_value);
                
                Destroy(gameObject);
              




            }

        }
        if (col.transform.tag == "PlayerTag")
        {
            Player.P_hp -= M_dmg;
            Player.P_value.GetComponent<Slider>().value = Player.P_hp;
            if (gameObject.transform.position.x < target.position.x)
            {
                target.Translate(0.3f, 0f, 0f);
            }
            else { target.Translate(-0.3f, 0f, 0f); }

            

        }


    }
}
