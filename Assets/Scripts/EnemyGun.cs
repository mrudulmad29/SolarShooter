using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBulletGo;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("FireEnemyBullet", 1f);
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
            Vector2 direction = playership.transform.position - bullet.transform.position;
            bullet.GetComponent<EnemyBullet>().SetDirection(direction);
        }
    }
}
