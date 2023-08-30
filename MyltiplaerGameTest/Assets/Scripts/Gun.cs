using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gun : MonoBehaviour
{
    [SerializeField] float damage;
    [SerializeField] float range;
    [SerializeField] float fireRate;

    [SerializeField] Transform playerPos;
    [SerializeField] Transform SpawnPoint;
    [SerializeField] GameObject bullet;

    private float nextFire;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >nextFire)
        {
            nextFire = Time.time+ fireRate;
            Shoot();
        }
        Debug.DrawRay(SpawnPoint.position, SpawnPoint.forward * range, Color.red);
    }

    private void Shoot()
    {
       
        Ray ray = new Ray(SpawnPoint.position, SpawnPoint.forward * range);
        Rigidbody rb;
       
        GameObject g = Instantiate(bullet, ray.origin, Quaternion.identity);
        rb = g.GetComponent<Rigidbody>();
        rb.velocity = ray.direction;
    }
}
