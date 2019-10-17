using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailControl : MonoBehaviour
{
    public GameObject Explosion;
    GameObject Hp;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject director = GameObject.Find("GameDirector");

        if (collision.gameObject.tag == "Bomb")
        {
            Destroy(collision.gameObject);
            GameObject effect =  Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(effect, 1.0f);

            director.GetComponent<GameDirector>().DecreaseHp();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float direction = 0;
        float speed = 5f * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -0.5f;
            if(transform.position.x >= -12.5)
                transform.Translate(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 0.5f;
            if(transform.position.x <=12.5)
                transform.Translate(speed, 0, 0);
        }

        if(direction != 0)
        {
            transform.localScale = new Vector3(direction, 0.5f, 1);
        }
    }
}
