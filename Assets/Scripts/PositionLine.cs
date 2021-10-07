using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLine : MonoBehaviour
{
    DrawLine dl;

    // Start is called before the first frame update
    void Start()
    {
        dl = GetComponent<DrawLine>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (dl.origin.transform.position + dl.other.transform.position) / 2;
    }
}
