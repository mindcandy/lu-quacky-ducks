using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	
	//speed controls how fast the pipes will move across the screen
	public int speed = -4;
	
	//these parameters control the y position of the pipes
	public float highestPosition = 2;
	public float lowestPosition = 0;
	
	//the width of the game screen used to reposition pipes when they go off it
	private const float SCREEN_WIDTH = 7.4f;
	
	void Start()
	{
		//setup the pipe keeping it's current x position but randomly choosing it's y
		InitializePipe(transform.position.x);
		//set the x velocity of the pipe to the speed value
		rigidbody2D.velocity = new Vector2(speed,0);
	}
	
	void Update()
	{
		//check to see if the pipe is no longer on the screen
		if(transform.position.x < -SCREEN_WIDTH)
		{
			//reset the position of the pipe
			InitializePipe(SCREEN_WIDTH);	
		}
	}
	
	private void InitializePipe(float x)
	{
		//sets the pipes position and randomly selects the y value based on highestPosition and lowestPosition
		float ranVal = Random.value * (lowestPosition + (highestPosition - lowestPosition));
		transform.position = new Vector2(x,ranVal);
	}
	
}
