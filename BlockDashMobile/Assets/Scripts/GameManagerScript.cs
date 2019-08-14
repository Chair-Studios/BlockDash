using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
	public float restartTime = 1f;
	bool gameIsOver = false;
	public GameObject completeTextUI;

	public void NextScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	private void FixedUpdate()
	{
	
		if (Input.GetKey(KeyCode.Space))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
		
		
	}

	public void EndGame ()
	{
		
		if (gameIsOver == false)
		{
		
			gameIsOver = true;
			Debug.Log("GameOver");
			Invoke("Restart", restartTime);
		}
		
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
		
	public void LevelPassed()
	{
		if (gameIsOver == false)
		{

				completeTextUI.SetActive(true);
			Invoke("NextScene", 4);
	
		}
	}
}
