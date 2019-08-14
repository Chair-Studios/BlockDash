using UnityEngine;

public class CollisonControler : MonoBehaviour
{
	public GameObject boostText;
	public bool Boosted;
	public PlayerMovement movement;

	public void BOOST()
	{
		Boosted = true;
	}

	private void OnCollisionEnter(Collision collisionInfo)
	{
		if (Boosted == true && collisionInfo.collider.tag == "Obstacle")
		{
			Debug.Log("Collision blocked by boost");
			Boosted = false;
			FindObjectOfType<CollorControler1>().Red();
			boostText.SetActive(false);
		}
		else if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
			FindObjectOfType<GameManagerScript>().EndGame();
		}
	}
}
