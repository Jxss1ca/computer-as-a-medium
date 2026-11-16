using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy2 : MonoBehaviour

{
    private float horizontalScreenLimit = 9.5f;
    private float enemyScreenLimit = 4f;
    public GameObject EnemyBulletPrefab;
    public float fireRate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("EnemyShooting", 1f, fireRate);

    }

    // Update is called once per frame

    void Update()
    {
        //This function is called every frame; 60 frames/second
        EnemyMovement();

    }
    void EnemyShooting()

    {
        Instantiate(EnemyBulletPrefab, transform.position + new Vector3(0, -1, 0), Quaternion.identity);
    }
    void EnemyMovement()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 4f);
        if (transform.position.y <= enemyScreenLimit)
            {
            transform.position = new Vector3(transform.position.x, enemyScreenLimit, 0);
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 2f); }
        if (transform.position.x >= horizontalScreenLimit)
        {
            Destroy(this.gameObject);
        }
    }
}