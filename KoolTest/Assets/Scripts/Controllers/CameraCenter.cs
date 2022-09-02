using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter : MonoBehaviour
{
    public List<Transform> go;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = newPosition;
    }

    Vector3 GetCenterPoint()
    {
        var bounds = new Bounds(go[0].position, Vector3.zero);
        for (int i = 0; i < go.Count; i++)
        {
            bounds.Encapsulate(go[i].position);
        }
        return bounds.center;
    }
}
