using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField playerName;
    public Text nameText;
    public static string myName = "You";

    public static float carSpeed = 10f;
    public Text carSpeedText;
    public Slider carSpeedSlider;

    public static float spawnSpeed = .3f;
    public Text spawnSpeedText;
    public Slider SpawnSpeedSlider;


    public void carSlider()
    {
        carSpeedText.text = carSpeedSlider.value.ToString();
        carSpeed = carSpeedSlider.value;
    }

    public void spawnSlider()
    {
        spawnSpeedText.text = SpawnSpeedSlider.value.ToString();
        spawnSpeed = SpawnSpeedSlider.value;
    }

    private int resetLives = 3;

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
        GameManager.playerLivesPass = resetLives;
    }

    public void InputName()
    {
        myName = playerName.text.ToString();
        nameText.text = myName.ToUpper();
    }

}
