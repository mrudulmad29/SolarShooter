using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBulletGo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireEnemyBullet", 1f, 1f);
    }

    private void InvokeRepeating(string v1, float v2)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FireEnemyBullet()
    {
        GameObject playership = GameObject.Find("PlayerGo");
        if (playership != null)
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBulletGo);
            bullet.transform.position = transform.position;
            bullet.GetComponent<EnemyBullet>().SetDirection(Vector2.down);
        }
    }
}
