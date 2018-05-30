using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour {

    #region Singleton


    #endregion


    Transform target;
    NavMeshAgent agent;
    Animator animu;
    bool punching = false;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animu = GetComponent<Animator>();
	}

    private void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
        if ((0 != agent.velocity.x) || (0 != agent.velocity.z))
        {
            animu.Play("Walk");
        }
        else
        {
            if (punching == false)
            {
                //animu.Play("Idle") ;
                animu.CrossFade("Idle", 0.2f);
            }
            else
            {
                animu.Play("HitAnimation");
                StartCoroutine(PunchTimer());
            }
        }
    }

    public void RetardedAirPunching()
    {
        Debug.Log("Thisfar"); 
        punching = true;
    }

    public void MoveToPoint (Vector3 point)
    {
        agent.SetDestination(point);
        //Debug.Log("Target is " + point);
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

    IEnumerator PunchTimer()
    {
        yield return new WaitForSeconds(0.8f);
        punching = false;
    }
}
