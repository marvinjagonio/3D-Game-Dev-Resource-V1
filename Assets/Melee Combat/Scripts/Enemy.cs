using System;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rayDistance;
    public LayerMask layerMask;
    private Vector2 enemyDirection;

    public int MaxHealth;
    public int currentHealth;

    public Transform target;
    public bool playerAttacked = false;

    private void Start()
    {
        currentHealth = MaxHealth;
    }
    private void Update()
    {
        EnemyRaycastDetection();

     
        if(playerAttacked)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), Time.deltaTime * 20);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        StartCoroutine(StartChasing());

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            
        }

    }

    private void EnemyRaycastDetection()
    {
        // Draw the ray in Scene View (for debugging)
        Debug.DrawRay(transform.position, transform.forward * rayDistance, Color.red);

        // Create the ray
        Ray ray = new Ray(transform.position, transform.forward);

        // Raycast hit result
        if (Physics.Raycast(ray, out RaycastHit hitInfo, rayDistance, layerMask))
        {
            Debug.Log("Detected");

            if (hitInfo.distance < 1.5f)
            {
                Debug.Log("Close to target");
            }
        }

    }

    IEnumerator StartChasing()
    {
        yield return new WaitForSeconds(3f);
        playerAttacked = true;
    }
}
