using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject barrel;
    Rigidbody bulletRB;
    public float bulletSpeed;
    public float timelimit;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = timelimit;
        bulletRB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.active == true)
        {
            bulletRB.velocity = transform.forward * bulletSpeed;
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                this.gameObject.SetActive(false);
                timer = timelimit;
                bulletRB.velocity = Vector3.zero;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.SetActive(false);
        timer = timelimit;
    }
}
