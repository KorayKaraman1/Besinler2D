using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public GameObject target;
    public Vector3 cameraofst;
    public Vector3 targetp;
    public Vector3 velo = Vector3.zero;
    public float keskinlik = 0.3f;
    // Update is called once per frame
    void LateUpdate()
    {
        targetp = target.transform.position + cameraofst;
        transform.position = Vector3.SmoothDamp(transform.position, targetp, ref velo, keskinlik);
    }
}
