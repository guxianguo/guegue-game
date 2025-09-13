using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class addcirle : MonoBehaviour
{
    // Start is called before the first frame update
    public static string Path = "addcirle";
    public static GameObject parent;
    public Sprite pic;

    public guegue guegue;
    void Start()
    {

        Debug.Log(Path + "start");
        parent = GameObject.FindGameObjectWithTag("Player");
        guegue = new guegue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            createcirle();
            //guegue.createmob();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            delcirle();
        }
    }
    public void createcirle()
    {
        GameObject ob = new GameObject();
        ob.transform.parent = parent.transform;
        ob.AddComponent(typeof(cirlecomponent));
        ob.tag = "spaner";
        ob.AddComponent(typeof(SpriteRenderer));
        SpriteRenderer a = ob.GetComponent<SpriteRenderer>();
        a.sprite = pic;
        a.sortingLayerName = "mover";
    }
    public void delcirle()
    {
        GameObject ob = GameObject.FindGameObjectWithTag("spaner");
        Destroy(ob);
    }
}
