using UnityEngine;
public class CommonTriggerBehaviors : ScriptableObject
{
    public static void DestroyOther(Collider2D other)
    {
        Debug.Log("Destroying " + other.name);
        Destroy(other.gameObject);
    }


    //Health Package Functions
#if HAS_HEALTH_SYSTEM

    public void DamageOther(Collider2D other, int damage)
    {
        if (other.TryGetComponent<Health>(out Health health))
        {
            health.Damage(damage);
        }
        else
        {
            Debug.LogWarning($"No <color=lime>Health</color> component found on {other.name}. Skipping damage dealing...");
        }
    }
    /// <summary>
    /// Destroys the specified 2D collider's associated GameObject.
    /// </summary>
    /// <remarks>This method destroys the GameObject attached to the specified collider</remarks>
    /// <param name="other">The Collider2D whose associated GameObject will be destroyed. Cannot be null.</param>
    /// <param name="unused">An int value used to absorb the input value from UnityEvent<Collider2D,int></param>
    public static void DestroyOther(Collider2D other, int unused)
    {
        Debug.Log("Destroying " + other.name);
        Destroy(other.gameObject);
    }
#endif
}
