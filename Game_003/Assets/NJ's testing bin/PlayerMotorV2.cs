using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotorV2 : MonoBehaviour {


    Transform traget;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
		
	}

    private void Update()
    {
        if(traget != null)
        {
            agent.SetDestination(traget.position);
            FaceTraget();
        }
    }

    public void MoveToPoint (Vector3 point)
    {
        agent.SetDestination(point);
    }

    public void FollowTraget (Interactable newTraget)
    {
        agent.stoppingDistance = newTraget.radius * 0.7f;
        agent.updateRotation = false;

        //traget = newTraget.interactionTransform;
    }
    public void StopFollowingTraget()
    {
        agent.stoppingDistance = 0f;
        agent.updateRotation = true;

        traget = null;
    }

    void FaceTraget()
    {
        Vector3 diraction = (traget.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(diraction.x, 0f, diraction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}
