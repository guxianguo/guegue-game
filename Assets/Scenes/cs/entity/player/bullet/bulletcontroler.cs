using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject master;
    public Rigidbody2D body;
    public float speed = 50;
    void Start()
    {
        master = GameObject.FindGameObjectWithTag("Player");
        body = gameObject.GetComponent<Rigidbody2D>();

        speedset();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void speedset()
    {
        Vector2 way = (stevetool.get_mouse_world_pos() - master.transform.position).normalized;
        body.velocity = speed * way;
        print(body.velocity.ToString());
    }

}
