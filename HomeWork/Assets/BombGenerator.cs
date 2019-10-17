using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject BombPrefab;
    float span = 1.0f;
    float delta = 0;
    int count = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if(delta > span)
        {
            delta = 0;
            count++;
            GameObject Gener = Instantiate(BombPrefab) as GameObject;
            int range = Random.Range(-12, 13);
            Gener.transform.position = new Vector3(range, 4.5f, 0);

            if (count % 10 == 0 && span >= 0.2f)
            {
                span -= 0.05f;
            }
        }
    }
}
