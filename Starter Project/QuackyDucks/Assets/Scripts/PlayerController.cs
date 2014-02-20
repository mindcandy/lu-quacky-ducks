using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float flapDistance = 8;//controls how high the player flys upwards
	public float flapDropoff = 0.6f;//controls how quickly the player falls down
	//public GameObject gameOverPrefab;
	//public TextMesh scoreText;

	//public AudioClip clickSound;
	//public AudioClip scoreSound;
	//public AudioClip crashSound;

	private Vector2 _velocity;
	//private int _score = 0;
	//private static int _bestScore = 0; //a static variable will not get reset when the game is reloaded
	//private Collider2D _lastColliderHit; //used to prevent getting multiple points from one pipe
	//private AudioSource _audioSource;

	// Use this for initialization
	void Start () 
	{
		_velocity = new Vector2(0,0); //initialise the speed of the player
		//_audioSource = GetComponent<AudioSource>(); //grab a reference to the audio source component
		//Time.timeScale = 1;	//set the speed of the game to 1
	}
	
	//Gets the mouse input and sets the velocity each frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			_velocity.y += flapDistance; //increase the players upward momentum
			//_audioSource.PlayOneShot(clickSound);
		}
		if(_velocity.y > 0)
		{
			_velocity.y -= flapDropoff; //reduce the players upward momentum
		}
	}

	//updates the players velocity every fixed frame
	void FixedUpdate() 
	{
		rigidbody2D.velocity = _velocity;	
	}

	/*
	//this handles the player passing through the trigger area in the middle of pipes
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(_lastColliderHit != collider)
		{
			_score++;
			scoreText.text = _score.ToString();
			_lastColliderHit = collider; // store this pipe object so we don't score it again
			//_audioSource.PlayOneShot(scoreSound);
		}
	}

	*/

/*	//this handles collisions with pipes and is used to end the game
	void OnCollisionEnter2D(Collision2D collision)
	{
		if(_score > _bestScore)
		{
			_bestScore = _score;
		}
		//Time.timeScale = 0; // set the game time to 0 to stop physics and animations
		GameObject gameOverScreen = Instantiate(gameOverPrefab) as GameObject;
		gameOverScreen.GetComponent<GameOver>().setScore(_score,_bestScore);
		//_audioSource.PlayOneShot(crashSound);

	}

*/
}
