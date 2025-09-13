using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobcontoler : MonoBehaviour
{
    // Start is called before the first frame update
    public stevedata data;
    public SpriteRenderer sr;
    public Rigidbody2D body;
    public Color originalcolor;
    public float flashtime = 0.2f;
    public float hit_force = 10000;
    void Start()
    {
        data = stevetool.get_data(this.gameObject);
        sr = gameObject.GetComponent<SpriteRenderer>();
        body = gameObject.GetComponent<Rigidbody2D>();
        originalcolor = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (data.hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            //print(collision.gameObject.ToString());
            stevedata bulletdata = stevetool.get_data(collision.gameObject);
            takedamage(bulletdata.atk);
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
        Invoke("reflash", time);
    }

    void reflash()
    {
        sr.color = originalcolor;
    }

    void hitedmove(GameObject hitsource)
    {
        Vector3 way = (gameObject.transform.position - hitsource.transform.position).normalized;

        body.AddForce(way * hit_force,ForceMode2D.Impulse);
    }
}
