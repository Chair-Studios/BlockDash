using UnityEngine;

public class CapsuleControler : MonoBehaviour
{
	public GameObject boostText;
	public Renderer ren;

	public void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player")

		{
			ren.enabled = false;

			boostText.SetActive(true);

			Debug.Log("BOOST");
			FindObjectOfType<CollorControler1>().BoostColor();
			FindObjectOfType<CollisonControler>().BOOST();
		}
	}
}
