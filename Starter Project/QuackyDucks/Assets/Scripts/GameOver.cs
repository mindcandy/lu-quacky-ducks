using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public TextMesh scoreText;
	public TextMesh bestScoreText;

	public void setScore(int currentScore, int bestScore)
	{
		//sets the score boards score values (note: numbers have to be converted to strings to be displayed as text)
		scoreText.text = currentScore.ToString();
		bestScoreText.text = bestScore.ToString();
	}
}
