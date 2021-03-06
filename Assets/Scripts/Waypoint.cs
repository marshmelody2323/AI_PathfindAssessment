using UnityEngine;

public class Waypoint : MonoBehaviour
{

    public Vector3 Position => transform.position;


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }
}