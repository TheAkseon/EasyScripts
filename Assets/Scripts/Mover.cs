using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector3.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(Vector3.back * _speed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _speed * Time.deltaTime);
        }
    }
}
