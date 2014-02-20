using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	void OnMouseDown()
	{
		//reload the game
		Application.LoadLevel("GameScene");
	}
}
