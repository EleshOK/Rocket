using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float _boostPower;
    [SerializeField] private float _rotationSpeed;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _boostPower = 1000f;
        _rotationSpeed = 300f;
    }

    void Update()
    {
        Trust();
        Rotate();
    }

    private void Trust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rb.AddRelativeForce(Vector3.up * _boostPower * Time.deltaTime);
        }

    }

    private void Rotate()
    {
        float deltaZ = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(deltaZ, 0, 0));
    }
}
