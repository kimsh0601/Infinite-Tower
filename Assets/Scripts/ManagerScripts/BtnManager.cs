using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour {


    public GameObject ReinFoce;
    public GameObject Panel;
    public GameObject Forgemax;
    public Text score;
    public Text count;

    private int counting;
    private int plus;
	// Use this for initialization
	void Awake () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GamePlay(){
		Application.LoadLevel("GamePlay");
	}
    public void BulidUP()
    {
        ReinFoce.SetActive(true);
        ReinFoce.GetComponent<Animator>().SetBool("Popup", true);
    }
    public void Dowm()
    {
        ReinFoce.GetComponent<Animator>().SetBool("Popup", false);
    }
    public void Forge()
    {
        Application.LoadLevel("Forge");
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Town");
    }
    public void PauseGame()
    {
        Panel.SetActive(true);
        Time.timeScale = 0;
    }
    public void ReturnGame()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Rainforce()
    {   if(plus != 10)
        {
            counting++;
            count.text = counting.ToString();
        }
        int value = Random.Range(1, 100);
        Debug.Log(value);
        if (plus < 5)
        {
            if (value <= 80)
            {
                plus++;
                score.text = plus.ToString();
                return;

            }
            else
            {
                plus--;
                if (plus < 0) plus = 0;
                score.text = plus.ToString();

                return;
            }

        }
        if (plus >= 5 && plus < 8)
        {
            if (value <= 50)
            {
                plus++;
                score.text = plus.ToString();
                return;
            }
            else
            {
                plus -= 2;
                score.text = plus.ToString();
                return;
            }

        }
        if (plus >= 8 && plus < 10)
        {
            if (value <= 30)
            {
                plus++;
                score.text = plus.ToString();
                if (plus == 10)
                {
                    Forgemax.SetActive(true);
                }
                return;

            }
            else
            {
                plus = 0;
                score.text = plus.ToString();
                return;
            }
            

        }
       








    }
}
