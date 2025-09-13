using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_bar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hp_bar;

    public stevedata data;
    void Start()
    {
        data = this.GetComponentInParent<stevedata>();
        hp_bar = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        hp_bar.transform.localScale = new Vector3(data.hp / data.maxhp, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);
    }
}
