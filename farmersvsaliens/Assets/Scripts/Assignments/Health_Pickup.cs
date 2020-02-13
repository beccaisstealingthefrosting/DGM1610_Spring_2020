using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Pickup : Pickup
{
    public int healthAmt = 100;


    // Start is called before the first frame update
    void Start()
    {
        print("Player is health is " + healthAmt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("You gained  " + healthAmt+ " health!");
        Destroy(gameObject);
    }



}
