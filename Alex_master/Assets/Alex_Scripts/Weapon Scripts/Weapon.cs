﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject bullet;
    public GameObject Platform;
    
    public Transform spawnPoint;
    
    

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Rigidbody2D>().AddForce
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {
            AudioManager.instance.PlaySFX(1);
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }

       



    }
}
