using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Square;
    void Start()
    {
        Console.WriteLine("hello world");
        Debug.Log("here");
        Square = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    }
    
}
