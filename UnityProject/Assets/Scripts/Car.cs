using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("汽車速度"),Range(10,100)]
    public int moveSpeed;
    [Header("旋轉速度"), Range(1, 100)]
    public int rotateSpeed;
    [Header("汽車檔次"), Range(1, 3)]
    public int carShift;
    [Header("汽車品牌")]
    public string brand;
    [Header("是否剎車")]
    public bool brakes;
    [Header("汽車顏色")]
    public Color color;
    [Header("汽車變形元件")]
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void CarMove()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void CarBack()
    {
        transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void CarLeft()
    {
        transform.Rotate(0, -rotateSpeed, 0);
    }

    public void CarRight()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }
}

