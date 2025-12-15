using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class TriggerCollider2D : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] private UnityEvent onTriggerEnter;
    [SerializeField] private UnityEvent onTriggerStay;
    [SerializeField] private UnityEvent ontriggerExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        onTriggerStay.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ontriggerExit.Invoke();
    }
}

