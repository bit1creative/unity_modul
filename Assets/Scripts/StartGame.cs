using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Rigidbody rb;
    public float force;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("HitBall", 3f);
    }

    void Update()
    {

    }

    private void HitBall()
    {
        rb.AddForce(new Vector3(0f, 0f, force), ForceMode.Impulse);
    }
}
