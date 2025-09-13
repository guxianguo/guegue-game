using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UIElements;

public class camercontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject master;
    public float R = 3;
    public Vector3 dispos;
    void Start()
    {
        master = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldpos = stevetool.get_mouse_world_pos();
        Vector3 mousepos = (worldpos + master.transform.position) / 2;
        Camera.main.transform.position = mousepos;
    }
}
