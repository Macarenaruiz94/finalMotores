using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedControl : MonoBehaviour
{
    public Rigidbody paredRB;
    public Transform[] paredPosition;
    public float paredSpeed;

    private int actualPosition = 0;
    private int nextPosition = 1;
    void Update()
    {
        MovePared();
    }

    void MovePared()
    {
        paredRB.MovePosition(Vector3.MoveTowards(paredRB.position, paredPosition[nextPosition].position, paredSpeed * Time.deltaTime));

        if (Vector3.Distance(paredRB.position, paredPosition[nextPosition].position) <= 0)
        {
            actualPosition = nextPosition;
            nextPosition++;
        }

        if (nextPosition > paredPosition.Length - 1)
        {
            nextPosition = 0;
        }
    }
}
