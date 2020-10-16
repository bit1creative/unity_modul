using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject youWinText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Invoke("Freeze", 0.1f);
    }

    public void Freeze()
    {
        youWinText.SetActive (true);
        Time.timeScale = 0f;
    }


}

