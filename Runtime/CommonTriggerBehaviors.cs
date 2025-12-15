using UnityEngine;

public class CommonTriggerBehaviors : MonoBehaviour
{
    public void Destroy(GameObject other)
    {
        Object.Destroy(other);
    }
}
