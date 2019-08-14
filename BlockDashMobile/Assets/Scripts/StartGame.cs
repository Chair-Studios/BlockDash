using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
	public GameObject TutorialText;

	public void LoadGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
