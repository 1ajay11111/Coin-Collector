using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] float Speedx;
    [SerializeField] float Speedy;
    [SerializeField] float Speedz;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * Speedx * Time.deltaTime, 360 * Speedy * Time.deltaTime, 360 * Speedz * Time.deltaTime);
    }
}
