using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

	public bool Left = false;
	public bool Right = false;

	public float forwardForce = 2000f;
	public float sideForce = 500f;
    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		
		if (Input.GetKey("d"))
		{
			rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))
		{
			rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -2f)
		{
			FindObjectOfType<GameManagerScript>().EndGame();
		}
	}

	public void GoLeft()
	{
		Left = true;
	}

	public void GoRight()
	{
		Right = true;
	}

	public void StopLeft()
	{
		Left = false;
	}

	public void StopRight()
	{
		Right = false;
	}

}
