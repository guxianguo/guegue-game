using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class mob
{
    public float health;
    public float speed;
    public float atk;
    public string pic;
    public string tag;
    public string layer;
    public GameObject creator;
    public float pixelsPerUnit;

    public GameObject createmob()
    {
        creator = new GameObject();

        add_component();
        spriteRenderer_init();
        boxCollider2D_init();
        rigidbody2D_init();

        creator.layer = LayerMask.NameToLayer(layer);
        creator.tag = tag;
        return creator;
    }

    public void add_component()
    {
        creator.AddComponent(typeof(SpriteRenderer));
        creator.AddComponent(typeof(Rigidbody2D));
        creator.AddComponent(typeof(BoxCollider2D));


    }
    public void spriteRenderer_init()
    {
        SpriteRenderer a = creator.GetComponent<SpriteRenderer>();
        Texture2D tex = Resources.Load<Texture2D>(pic);
        // Debug.Log("1 sprite ok");
        // Debug.Log("2 " + a.ToString());
        // Debug.Log("2.5 " + pic);
        // Debug.Log("3 " +tex.ToString());
        // Debug.Log("4 " +Resources.Load<Texture>(pic).ToString());
        a.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f),pixelsPerUnit);
    }

    public void rigidbody2D_init()
    {
        Rigidbody2D b = creator.GetComponent<Rigidbody2D>();
        b.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        b.interpolation = RigidbodyInterpolation2D.Interpolate;
        //b.simulated = false;
        b.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void boxCollider2D_init()
    {
        BoxCollider2D c = creator.GetComponent<BoxCollider2D>();
        Texture2D tex = Resources.Load<Texture2D>(pic);
        //c.size = new Vector2(tex.width,tex.width);
        c.size = new Vector2(1,1);
    }
}


public class guegue : mob
{
    public guegue(float hp = 1,
                  float speed = 1,
                  float atk = 1,
                  string pic = "man/guegue2",
                  string tag = "enemy",
                  string layer = "mover",
                  float pixelsPerUnit =64
                  )
    {
        this.health = hp;
        this.speed = speed;
        this.atk = atk;
        this.pic = pic;
        this.layer = layer;
        this.tag = tag;
        this.pixelsPerUnit = pixelsPerUnit;
    }

}