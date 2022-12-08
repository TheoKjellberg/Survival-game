using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;

    [SerializeField]
    float speed;

    Rigidbody2D rb;
    PlayerShootScript shootScript;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shootScript = GetComponent<PlayerShootScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.(shootScript.direction);
        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //Get the angle between the points
        float angle = Mathf.Atan2(positionOnScreen.y - mouseOnScreen.y, positionOnScreen.x - mouseOnScreen.x) * Mathf.Rad2Deg;// (positionOnScreen, mouseOnScreen);

        //Ta Daaa
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle + 90));

        if (rb.velocity.x < 6 && Input.GetKey(right))
        {
            rb.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        }
        if (rb.velocity.x > -6 && Input.GetKey(left))
        {
            rb.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
        }
        if (rb.velocity.y < 6 && Input.GetKey(up))
        {
            rb.AddForce(new Vector2(0, speed), ForceMode2D.Impulse);
        }
        if (rb.velocity.y > -6 && Input.GetKey(down))
        {
            rb.AddForce(new Vector2(0, -speed), ForceMode2D.Impulse);
        }

    }
}
