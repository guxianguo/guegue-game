using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hp_ui : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI text;
    public stevedata data;
    public Image image;
    void Start()
    {
        data = stevetool.get_data(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        uiup();
    }

    void uiup()
    {
        image.transform.localScale = new Vector3(data.hp / data.maxhp, image.transform.localScale.y, image.transform.localScale.z);
        text.text = data.hp.ToString() + " / " + data.maxhp.ToString();
    }

}
