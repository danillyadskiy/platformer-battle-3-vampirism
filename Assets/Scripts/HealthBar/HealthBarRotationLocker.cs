using UnityEngine;

public class HealthBarRotationLocker : MonoBehaviour
{ 
    private void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }
}
