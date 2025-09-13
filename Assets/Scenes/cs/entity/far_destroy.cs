using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class far_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject master;
    public float distance;
    void Start()
    {
        master = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (stevetool.count_distance(this.gameObject, master) > distance)
        {
            Destroy(this.gameObject);
        }
    }


}
