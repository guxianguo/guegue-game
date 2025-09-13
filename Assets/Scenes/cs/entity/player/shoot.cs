using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public int count = 0;
    public int speed = 1;
    public int limit = 10000;
    public GameObject bullet_obj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fire();
    }

    void fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet_obj, this.gameObject.transform.position, quaternion.identity);
            return;
        }

        if (Input.GetMouseButton(0))
        {
            if (count == 0)
            {
                Instantiate(bullet_obj, this.gameObject.transform.position, quaternion.identity);
            }
            count += speed;
            if (count >= limit)
            {
                count = 0;
            }
        }
    }
}
