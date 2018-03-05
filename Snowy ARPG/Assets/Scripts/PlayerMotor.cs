﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour {

    Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}

    private void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            
        }
    }

    public void MoveToPoint (Vector3 point)
    {
        agent.SetDestination(point);
        Debug.Log("Target is " + point);
    }

    public void FollowTarget(Interactable newTarget)
    {
        target = newTarget.transform;
    }
    public void StopFollowingTarget()
    {
        target = null;
    }
    public void ReceiveRemotePosition(Vector3 pos)
    {
        agent.SetDestination(pos);
    }
}