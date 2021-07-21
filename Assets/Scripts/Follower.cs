using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private float maxShiftLeft = 1;
    [SerializeField] private float maxShiftRight = 1;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {    
                Vector3 dir = Vector3.right * touch.deltaPosition.x * speed;

                if(transform.position.x + dir.x > maxShiftLeft && transform.position.x + dir.x < maxShiftRight)
                    transform.position += dir;

              
            }
        }
    }
}
