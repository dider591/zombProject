using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookDistanceTransition : Transition
{
    [SerializeField] private float _transitionRange;


    private void Update()
    {
        if (Vector3.Distance(transform.position, Target.transform.position) < _transitionRange)
        {
            NeedTransit = true;
        }
    }
}
