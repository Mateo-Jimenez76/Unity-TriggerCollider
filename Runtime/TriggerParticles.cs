using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public void TriggerParticles : Monobehavior
{
    [SerializeField] private UnityEvent onParticleTrigger = new();
    

    private new ParticleSystem particleSystem;
    private List<ParticleSystem.Particle> particles = new();

    private void Awake()
    {
        if(TryGetComponent<ParticleSystem>(out ParticleSystem system))
        {
            particleSystem = system;
        } else
        {
            particleSystem = gameObject.AddComponent<ParticleSystem>();
            var trigger = particleSystem.trigger;
            trigger.enabled = true;
            trigger.enter = ParticleSystemOverlapAction.Callback;
        }
    }

    private void OnParticleTrigger()
    {
        //Populate list
        particleSystem.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, particles);

        //For each particle, invoke the event
        foreach (ParticleSystem.Particle particle in particles)
        {
            onParticleTrigger.Invoke();
        }
    }
}
