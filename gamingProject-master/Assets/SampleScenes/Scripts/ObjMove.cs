﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    public GameObject obj2;
    private Vector3 direction = new Vector3(0, 0, -2);
    private Vector3 angle = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime, Space.World);
        transform.Rotate(angle, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<player>().TakeDamage(3);
        Destroy(gameObject);
    }
}