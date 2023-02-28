using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;

public class Trigger1 : MonoBehaviour
{
    private ParticleSystem Fire;

    void Start()
    {
        Fire = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Log")
        {
            Fire.Play();
        }
    }
}
