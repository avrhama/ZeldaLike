using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        float x = Mathf.Max(Mathf.Min(target.position.x,maxPosition.x),minPosition.x);
        float y = Mathf.Max(Mathf.Min(target.position.y, maxPosition.y), minPosition.y);
       // x = target.position.x;
        //y = target.position.y;
        Vector3 v = new Vector3(x, y, transform.position.z);
       // Vector3 v = new Vector3(target.position.x, target.position.y, transform.position.z);

        if (transform.position != target.position)
        {
            transform.position = Vector3.Lerp(transform.position,v, smoothing);
        }
    }
}
