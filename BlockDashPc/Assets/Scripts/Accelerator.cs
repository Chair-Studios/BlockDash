using UnityEngine;

public class Accelerator : MonoBehaviour
{
	bool accelerated = false;
	public Rigidbody playerRB;
	public float accelerateForce;

	public void OnTriggerEnter(Collider triggerInfo)
	{
		if (triggerInfo.tag == "Player")
		{
			if (accelerated == false)
			{
				accelerated = true;
				Debug.Log("Accelerator");
				playerRB.AddForce(0, 0, accelerateForce);
			}
		}

	}

	private void OnTriggerExit()
	{
		accelerated = false;
	}

	
}
