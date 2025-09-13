using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    // Start is called before the first frame update

    public stevedata data;
    public float flashtime = 0.2f;
    public SpriteRenderer sr;
    public Color originalcolor;
    public Rigidbody2D body;
    public float hit_force = 1000;

    void Start()
    {
        data = stevetool.get_data(this.gameObject);
        body = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        originalcolor = sr.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.tag == "enemy")
        {
            stevedata mobdata = stevetool.get_data(collision.gameObject);
            takedamage(mobdata.atk);
            hitedmove(collision.gameObject);
        }
    }

    void takedamage(float at)
    {
        data.hp -= at;
        flash(flashtime);
    }

    void flash(float time)
    {
        sr.color = Color.red;
        Invoke("reflashed", time);
    }

    void reflashed()
    {
        sr.color = originalcolor;
    }

    void hitedmove(GameObject hitsource)
    {
        Vector3 way = (gameObject.transform.position - hitsource.transform.position).normalized;

        body.AddForce(way * hit_force,ForceMode2D.Impulse);
    }
}
