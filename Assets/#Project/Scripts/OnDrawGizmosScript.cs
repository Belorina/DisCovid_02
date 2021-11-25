using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrawGizmosScript : MonoBehaviour
{
    public float radius = 1f;


    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 0f, 1f, 0.4f);
        Gizmos.DrawSphere(transform.position, radius);
    }
}
