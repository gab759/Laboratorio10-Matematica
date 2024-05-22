using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile1 : MonoBehaviour
{
    [SerializeField] private Rigidbody myRB;

    private void Start() {
        myRB = GetComponent<Rigidbody>();
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void Update() {
        float angle = Mathf.Atan2(myRB.velocity.y, myRB.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
