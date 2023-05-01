using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateBullet : MonoBehaviour
{
    public int score = 0;
    float currentTime = 0;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        currentTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > 2)
        {
            //x = -4 ~ 4, y = 4, z= 0인 위치에서 랜덤 생성
            Instantiate(bullet, new Vector3(Random.Range(-4.0f, 4.0f), 4, 0),  Quaternion.identity);
            currentTime = 0;
        }

    }

    public void getScore()
    {
        score++;
    }
    
}
