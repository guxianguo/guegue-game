using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gametitle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Animator p;
    public ParticleSystem particle;
    void Start()
    {
        p = player.GetComponent<Animator>();
        p.speed = 0;
    }

    // Update is called once per frame

    public void gamestart()
    {
        print("start");
        Invoke("stop_par", 1);
    }

    public void stop_par()
    {
        particle.Stop();
        Invoke("start_ani", 2);
    }

    public void start_ani()
    {
        p.speed = 1;
        Invoke("turn", 3);
    }
    public void turn()
    {
        player.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
