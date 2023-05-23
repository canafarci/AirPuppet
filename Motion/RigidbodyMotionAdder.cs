using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMotionAdder : MonoBehaviour
{
    //public

    //private
    [SerializeField]  Rigidbody _rigidbody;
    [SerializeField] Vector3 _direction;
    [SerializeField] Transform _targetTransform;
    //monobehaviour methods

    //public methods

    public void OnEndGameAddForce() => AddForce(_direction, _targetTransform);

    //private methods
    private void AddForce(Vector3 force, Transform targetTransform)
    {
        Vector3 direction = targetTransform.position - transform.position;
        direction = Vector3.Normalize(direction);
        direction.y = direction.y / 25f;
        _rigidbody.AddForce(direction * 50f, ForceMode.Impulse);
        print("called");
    }
}
