using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] MyVector a = new MyVector(2, 2);
    [SerializeField] MyVector b = new MyVector(-1, 3);
    [SerializeField] [Range(0, 1)] float tamaño;

    MyVector resta;
    MyVector suma;

    void Awake()
    {

    }

    void Update()
    {
        resta = b - a;
        suma = a.Lerp(b, tamaño);

        a.Draw(Color.red);
        b.Draw(Color.blue);
        suma.Draw(Color.yellow);
        resta.Draw(Color.green);
    }
}
