using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneOnTriggerEnter3D : MonoBehaviour
{
	public string requiredTag;
	public string targetScene;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag(requiredTag))
		{
			SceneManager.LoadScene (targetScene);
		}
	}
}
