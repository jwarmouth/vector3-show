using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DrawLine : MonoBehaviour
{
    public GameObject origin;
    public GameObject other;
    public LineRenderer lr;
    public Text ui;
    public TextMeshProUGUI tm;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        tm = GetComponentInChildren<TextMeshProUGUI>();
        if (origin == null)
        {
            origin = GameObject.Find("Origin");
        }
        if (other == null)
        {
            other = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (lr != null)
        {
            lr.SetPosition(0, origin.transform.position);
            lr.SetPosition(1, other.transform.position);
        }
        if (tm != null)
        {
            tm.text = (other.transform.position - origin.transform.position).ToString();
        }
    }
}
