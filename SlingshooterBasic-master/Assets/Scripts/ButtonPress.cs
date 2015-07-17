using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour {
	
	public void NextLevelButton(string Game)
	{
		Application.LoadLevel(Game);
	}
}
