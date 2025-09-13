using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class stevetool : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public static stevetool ins;

    public void Awake()
    {
        ins = this;
    }
    public static Vector3 get_mouse_world_pos()
    {
        Vector3 mousepos = Input.mousePosition;
        mousepos.z = Camera.main.transform.position.z;
        mousepos = Camera.main.ScreenToWorldPoint(mousepos);
        return mousepos;
    }

    public static Vector3 get_screen_world_pos(GameObject gameObject)
    {
        Vector3 pos = gameObject.transform.position;
        pos = Camera.main.WorldToScreenPoint(pos);
        return pos;
    }

    public static GameObject create_instance(string path, Vector3 pos, quaternion quaternion)
    {
        GameObject ob = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        Instantiate(ob, pos, quaternion);
        return ob;
    }

    public static float count_distance(GameObject a, GameObject b)
    {
        return (a.transform.position - b.transform.position).magnitude;
    }

    public static stevedata get_data(GameObject ob)
    {
        stevedata a = ob.GetComponent<stevedata>();
        return a;
    }
}
