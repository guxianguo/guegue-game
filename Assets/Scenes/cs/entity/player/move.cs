using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 400f;
    public float jumpspeed = 1200;
    public float maxspeed = 7;
    public Rigidbody2D body;

    [System.Runtime.InteropServices.DllImport("user32.dll")] //引入dll
    public static extern int SetCursorPos ( int x , int y );
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        Vector2 pos = stevetool.get_screen_world_pos(gameObject);
        SetCursorPos((int)pos.x,(int)pos.y);
    }

    // Update is called once per frame
    void Update()
    {
        movecontrol();
    }

    void movecontrol()
    {
        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);
        }
        if (body.velocity.x > maxspeed)
        {
            body.velocity = new Vector2(maxspeed, body.velocity.y);
        }
        if (body.velocity.x < -maxspeed)
        {
            body.velocity = new Vector2(-maxspeed, body.velocity.y);
        }
    }
}
