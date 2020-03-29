using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleSet : MonoBehaviour
{
    ParticleSystem clickParticle;

    private void Start()
    {
        clickParticle = GetComponent<ParticleSystem>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            clickParticle.enableEmission = false;
        }
    }
}
