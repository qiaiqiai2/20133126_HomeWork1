using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject HP;
    GameObject Score;
    GameObject Gameover;
    GameObject Snail;
    GameObject BombGenerator;
    GameObject Result;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        HP = GameObject.Find("HP");
        Score = GameObject.Find("Score");
        Gameover = GameObject.Find("GameOver");
        Snail = GameObject.Find("Snail");
        BombGenerator = GameObject.Find("BombGenerator");
        Result = GameObject.Find("Result");
    }

    // Update is called once per frame
    void Update()
    {
        if(HP.GetComponent<Image>().fillAmount == 0)
        {
            Destroy(Snail.gameObject);
            Destroy(BombGenerator.gameObject);
            Gameover.GetComponent<Text>().text = "GAME OVER";
            Result.GetComponent<Text>().text = "Score : " + Score.GetComponent<Text>().text;
        }
    }

    public void DecreaseHp()
    {
        HP.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseScore()
    {
        count += 100;
        Score.GetComponent<Text>().text = count.ToString("D");
    }
}
