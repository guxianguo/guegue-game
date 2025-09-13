using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class cirlecomponent : MonoBehaviour
{
    // Start is called before the first frame update
    public int R = 3;
    public float degrees = 0;
    public float speed = 0.1f;
    void Start()
    {
        Debug.Log(this.name + "start round");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 a = new Vector2(R * math.sin(degrees * Mathf.Deg2Rad), R * math.cos(degrees * Mathf.Deg2Rad));
        degrees += speed;
        if (degrees >= 360)
        {
            degrees = 0;
        }
        this.gameObject.transform.localPosition = a;
    }
}
