using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    public ParticleSystem particleEffect;
    public float minDelay = 5f;
    public float maxDelay = 10f;

    private float timer;

    private void Start()
    {
        timer = Random.Range(minDelay, maxDelay);
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            TriggerParticleEffect();
            timer = Random.Range(minDelay, maxDelay);
        }
    }

    private void TriggerParticleEffect()
    {
        if (particleEffect != null)
        {
            ParticleSystem newParticleEffect = Instantiate(particleEffect, transform.position, Quaternion.identity);
            Destroy(newParticleEffect.gameObject, newParticleEffect.main.duration);
        }
    }
}