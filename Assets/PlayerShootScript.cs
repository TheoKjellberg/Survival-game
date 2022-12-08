using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootScript : MonoBehaviour
{
    [SerializeField]
    KeyCode shoot;
    [SerializeField]
    GameObject Bullet;
    public Vector3 direction;
    Vector3 worldmouse;
    float shootTimer;
    public Vector2 mousePos;
    public int shot = 0;
    public bool canShoot;
    public float shootDelay;
    // Start is called before the first frame update
    public virtual void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    public virtual void Update()
    {
        mousePos = Input.mousePosition;
        worldmouse = Camera.main.ScreenToWorldPoint(mousePos);
        direction = new Vector3(worldmouse.x - transform.position.x, worldmouse.y - transform.position.y, 0).normalized;
        shootTimer += Time.deltaTime;
        if (Input.GetKey(shoot) && shootTimer >= shootDelay && canShoot)
        {
            shot += 1;
            Instantiate(Bullet, transform.position, Quaternion.identity);
            shootTimer = 0;
        }
    }
}
