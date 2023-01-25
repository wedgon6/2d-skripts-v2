using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayCheker : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] float _speed;
    [SerializeField] ContactFilter2D _filter;
    private readonly RaycastHit2D[] _results = new RaycastHit2D[1];

    private void FixedUpdate()
    {
        var collitionCount = _rigidbody2D.Cast(transform.right,_filter,_results,10);

        if(collitionCount == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
    }
}
