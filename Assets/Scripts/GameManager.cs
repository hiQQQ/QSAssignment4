using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Score
    public static string userName;
    public static int CurrentScore = 0;

    //Speed
    public static float speed = 1f;
    public static float minSpeed = 8f;
    public static float maxSpeed = 12f;

    //Spawn Info
    public static float spawnTime = .3f;
    public static float nextTimeToSpawn = 0f;

    //UI Info
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject pregameMenu;

    public Slider speedSlider;
    public Slider spawnSlider;

    public InputField nameInput;

    public Text speedLabel;
    public Text spawnLabel;
    public Text nameDisplay;

    public void SettingsButton()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
        pregameMenu.SetActive(false);
    }

    public void MenuButton()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
        pregameMenu.SetActive(false);
    }

    public void PregameButton()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(false);
        pregameMenu.SetActive(true);
    }

    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitButton()
    {

    }

    public void ExitMenuButton()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void SliderFunction()
    {
        speed = speedSlider.value;
        speedLabel.text = speed.ToString("0.00");
        spawnTime = spawnSlider.value;
        spawnLabel.text = spawnTime.ToString("0.00");
    }

    public void NameFunction()
    {
        userName = nameInput.text;
        nameDisplay.text = userName;
    }

}
