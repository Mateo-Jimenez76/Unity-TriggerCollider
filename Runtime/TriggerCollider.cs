using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerCollider : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] private UnityEvent onTriggerEnter;
    [SerializeField] private UnityEvent onTriggerStay;
    [SerializeField] private UnityEvent ontriggerExit;

    private void OnTriggerEnter(Collider collision)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerStay(Collider collision)
    {
        onTriggerStay.Invoke();
    }

    private void OnTriggerExit(Collider collision)
    {
        ontriggerExit.Invoke();
    }
}
