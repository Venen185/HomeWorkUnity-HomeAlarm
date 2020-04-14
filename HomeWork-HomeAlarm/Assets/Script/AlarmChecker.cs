using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmChecker : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] float _speed;
    private readonly RaycastHit2D [] _result = new RaycastHit2D [1];

    private void FixedUpdate() 
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
        var collisionCount = _rigidbody2D.Cast(transform.right, _result, 10);

        if (collisionCount == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;

        }
    }
}
