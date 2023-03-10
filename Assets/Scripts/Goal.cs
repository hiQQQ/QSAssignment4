using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Text scoreText;
    public GameObject frogger;

    void OnTriggerEnter2D()
    {
        GameManager.CurrentScore += 100;
        scoreText.text = GameManager.CurrentScore.ToString();
        frogger.transform.position = new Vector2(0, -4);
    }
}
