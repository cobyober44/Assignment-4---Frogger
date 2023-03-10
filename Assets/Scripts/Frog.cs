using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;

	public GameObject theFrog;
	public AudioSource source;
	public AudioClip clip;
	public static int lives = 3;
	private int livesPass;
	public Text livesText;

	WriteScores theScript;

	void Start()
	{
		livesText.text = "Lives: " + lives.ToString();
		theScript = GameObject.FindGameObjectWithTag("Frog").GetComponent<WriteScores>();
	}

	void Update () {

		if (Input.GetKeyDown(KeyCode.D))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.A))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.W))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.S))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			livesPass = lives;
			theFrog.SetActive(false);
            source.PlayOneShot(clip);
            if (lives > 1)
			{
				livesPass--;
				lives = livesPass;
				Invoke("RestartLevel", 1.5f);
			}
            else
            {
                Invoke("Exit", 1.5f);
                theScript.AddNewScore();
				Score.currentScore = 0;
            }
        }
	}

	void RestartLevel()
	{
        theFrog.SetActive(true);
        SceneManager.LoadScene("Main");
	}

	void Exit()
	{
        theFrog.SetActive(true);
        SceneManager.LoadScene("Exit");
		livesPass = 3;
		lives = livesPass;
    }
}
