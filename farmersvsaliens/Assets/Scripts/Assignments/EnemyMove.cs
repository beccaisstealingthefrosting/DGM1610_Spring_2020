using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    private Rigidbody enemyRb;
    //public int damage;
    public float moveSpeed;
    



    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        target = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);


    }








}
