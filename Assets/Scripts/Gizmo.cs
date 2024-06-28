using UnityEngine;

public class Gizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
        Vector3 distance = new Vector3(100, 100, 100);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.position + distance);
    }
}
