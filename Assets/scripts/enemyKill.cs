using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKill : MonoBehaviour
{
    private ParticleSystem particle;
    private SpriteRenderer spriteRenderer;

    public void Awake(){
        particle = GetComponentInChildren<ParticleSystem>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public IEnumerator kill(){
        particle.Play();
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
        Destroy(this.gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("bullet")){
            StartCoroutine(kill());
        }
    }
}
