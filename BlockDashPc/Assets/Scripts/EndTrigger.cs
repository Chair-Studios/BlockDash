using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManagerScript gameManager;

	public void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Player")
		{
			Debug.Log("Level Complete");
			gameManager.LevelPassed();
		}
		
	}

}
