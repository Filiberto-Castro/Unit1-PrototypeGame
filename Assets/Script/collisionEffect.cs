using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionEffect : MonoBehaviour
{
    public ParticleSystem collisionParticle;

    private void Start() {
        collisionParticle.Stop();
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player"))
        {
            collisionParticle.Play();
        }
    }
}
