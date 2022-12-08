using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    PlayerShootScript playerScript;
   
    float bulletSpeed = 10;
    float bulletTimer;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = FindObjectOfType<PlayerShootScript>();
        

        transform.eulerAngles = new Vector3(0, 0, -(Mathf.Atan2(playerScript.direction.x, playerScript.direction.y) * Mathf.Rad2Deg));  //g�r s� att skottet roteras mot d�r muspekaren var n�r man sk�t
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletTimer += Time.deltaTime;
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
        if (bulletTimer >= 3)
        {
            Destroy(gameObject);
        }

    }
}
