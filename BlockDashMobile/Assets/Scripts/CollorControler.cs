using UnityEngine;

public class CollorControler : MonoBehaviour
{
	public Renderer player;

	private void Start()
	{
		player = GetComponent<Renderer>();
		player.material.SetColor("_Color", Color.red);
	}

	public void Red()
	{
		player.material.SetColor("_Color", Color.red);
	}

	public void BoostColor()
	{
		player.material.SetColor("_Color", Color.magenta);
		
	}
	
		
	
}
