using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarScriptie : MonoBehaviour
{

    public GameObject PlayerBulletGo;
    public GameObject BulletPosition01;
    public GameObject BulletPosition02;
    // Start is called before the first frame update
    public float moveSpeed = 3f;
    public float speed;
    float velX;
    float velY;
    bool facingRight = true;
    Rigidbody2D rigBody;
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGo);
            bullet01.transform.position = BulletPosition01.transform.position;

            GameObject bullet02 = (GameObject)Instantiate(PlayerBulletGo);
            bullet02.transform.position = BulletPosition02.transform.position;

        }
        velX = Input.GetAxisRaw("Horizontal");
        velY = rigBody.velocity.y;
        rigBody.velocity = new Vector2(velX * moveSpeed, velY);

    }
    void LateUpdate()
    {
        Vector3 localScale = transform.localScale;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }
        if (velX > 0)
        {
            facingRight = true;

        }
        else if (velX < 0)
        {
            facingRight = false;

        }
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;


        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        transform.position = viewPos;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "enemy") || (other.tag == "EnemyBullet"))
        {
            Destroy(gameObject);
        }
    }
}
