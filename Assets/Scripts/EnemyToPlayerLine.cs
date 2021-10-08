using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyToPlayerLine : MonoBehaviour
{
    public Transform[] capsules;
    public TextMeshProUGUI[] texts;

    private LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineVector = capsules[1].position - capsules[0].position;
        //Vector3 endPoint = capsules[1].position - (capsules[1].position - capsules[0].position).normalized;
        lr.SetPosition(0, capsules[0].position);
        lr.SetPosition(1, capsules[1].position - lineVector.normalized / 1.5f);

        

        texts[0].text = capsules[0].position.ToString();
        texts[1].text = capsules[1].position.ToString();
        texts[2].text = lineVector.ToString();

    }
}
