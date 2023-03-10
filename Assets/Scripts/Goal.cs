using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.currentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}


//CurrentScore