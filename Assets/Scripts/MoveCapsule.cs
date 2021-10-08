using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(up))
            transform.Translate(Vector3.forward);
        if (Input.GetKeyDown(down))
            transform.Translate(Vector3.back);
        if (Input.GetKeyDown(left))
            transform.Translate(Vector3.left);
        if (Input.GetKeyDown(right))
            transform.Translate(Vector3.right);
    }
}
