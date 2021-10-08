using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawLine : MonoBehaviour
{
    public Transform origin;
    public LineRenderer lr;
    public TextMeshProUGUI tm;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        tm = GetComponentInChildren<TextMeshProUGUI>();
        origin = GameObject.Find("Origin").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineVector = transform.position - origin.position;

        lr.SetPosition(0, origin.position);
        lr.SetPosition(1, transform.position - lineVector.normalized / 1.5f);

        tm.text = lineVector.ToString();
    }
}
