using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node[] perents;
    public Node[] children;

    private void OnDrawGizmos()
    {
        if (children.Length > 0)
        {
            for (int i = 0; i < children.Length; i++)
            {
                Debug.DrawLine(transform.position, children[i].transform.position, Color.blue);
            }
        }
    }
}
