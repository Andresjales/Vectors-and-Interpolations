using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// My 2D Vector Class
/// </summary>
[System.Serializable]
public class MyVector
{
    [SerializeField] float x, y;

    public MyVector(float X, float Y)
    {
        x = X;
        y = Y;
    }

    public override string ToString()
    {
        return ("(" + x + "," + y + ")");
    }

    public MyVector Lerp(MyVector b, float tamaño)
    {
        return this + (b - this) * tamaño;
    }

    /*public MyVector Add(MyVector vec)
    {
        return new MyVector(x + vec.x, y + vec.y);
    }*/

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y);
    }

    /*public MyVector Substract(MyVector vec)
    {
        return new MyVector(x - vec.x, y - vec.y);
    }*/

    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y);
    }

    /*public MyVector MultEsc(float esc)
    {
        return new MyVector(esc * x, esc * y);
    }*/

    public static MyVector operator *(MyVector a, float esc)
    {
        return new MyVector(esc * a.x, esc * a.y);
    }

    public float Magnitude()
    {
        return Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
    }

    public MyVector Normalize()
    {
        return new MyVector(x / Magnitude(), y / Magnitude());
    }

    public void Draw(Color color)
    {
        Debug.DrawLine(Vector3.zero, new Vector3(x, y, 0), color);
    }

    public void Draw(MyVector c, Color color)
    {
        Debug.DrawLine(new Vector3(c.x, c.y, 0), new Vector3(x + c.x, y + c.y, 0), color);
    }
}
