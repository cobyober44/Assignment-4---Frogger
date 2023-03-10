using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	public Text playerName;

	private int playerLives;
	public static int playerLivesPass = 3;

	private int yourScore;
	public static int yourScorePass = 0;
	public Text yourScoreText;

	public Text lifeText;

    public void Start()
    {
		playerName.text = "Good Luck " + Menu.myName + "!";
		playerLives = playerLivesPass;
		lifeText.text = "Lives: " + playerLives.ToString();

		yourScoreText.text = yourScorePass.ToString();
    }

    public void EndGame()
	{
		if (gameHasEnded)
			return;

		gameHasEnded = true;
	}

	public void RestartLevel()
	{
		if (playerLives >= 2)
		{
			playerLives--;
			playerLivesPass = playerLives;
			yourScore = Score.currentScore - 1;

			if (yourScore > yourScorePass)
				yourScorePass = yourScore;

			SceneManager.LoadScene("Main");
			
		}
		else
		{
            yourScore = Score.currentScore - 1;

            if (yourScore > yourScorePass)
                yourScorePass = yourScore;

            SceneManager.LoadScene("Exit");
		}

	}
}
