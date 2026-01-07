using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class TriggerCollider2D : MonoBehaviour
{
#if !HAS_HEALTH_SYSTEM
    [Header("Events")]
    [SerializeField] private UnityEvent<Collider2D> onTriggerEnter;
    [SerializeField] private UnityEvent<Collider2D> onTriggerStay;
    [SerializeField] private UnityEvent<Collider2D> ontriggerExit;
#else
    [SerializeField] private UnityEvent<Collider2D,int> onTriggerEnter;
    [SerializeField] private UnityEvent<Collider2D,int> onTriggerStay;
    [SerializeField] private UnityEvent<Collider2D,int> onTriggerExit;
#endif

    [Header("Health System Settings")]
    [SerializeField] private int damageAmount = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
#if !HAS_HEALTH_SYSTEM
        onTriggerEnter.Invoke(collision);
#else
        onTriggerEnter.Invoke(collision, damageAmount);
#endif
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
#if !HAS_HEALTH_SYSTEM
        onTriggerStay.Invoke(collision);
#else
        onTriggerStay.Invoke(collision, damageAmount);
#endif
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
#if !HAS_HEALTH_SYSTEM
        onTriggerExit.Invoke(collision);
#else
        onTriggerExit.Invoke(collision, damageAmount);
#endif
    }
}

