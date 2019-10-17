using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombControl : MonoBehaviour
{
    GameObject Director;
    int rotate_direction;

    // Start is called before the first frame update
    void Start()
    {
        Director = GameObject.Find("GameDirector");
        rotate_direction = Random.Range(-2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, rotate_direction);

        if(transform.position.y < -6.0f)
        {
            Destroy(gameObject);
            Director.GetComponent<GameDirector>().IncreaseScore();
            
        }
    }
}
