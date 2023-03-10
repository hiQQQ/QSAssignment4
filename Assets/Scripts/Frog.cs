using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Frog : MonoBehaviour
{
	WriteScores neededScript;

    public Rigidbody2D rb;
	public GameObject audioPlay;
	public GameObject Frogge;

	void Start()
	{ 
		neededScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<WriteScores>();
    }

	void Update()
    {
	    if (Input.GetKeyDown(KeyCode.D))
		{
		    rb.MovePosition(rb.position + Vector2.right);
        }
		else if (Input.GetKeyDown(KeyCode.A))
		{
		    rb.MovePosition(rb.position + Vector2.left);
        }
		else if (Input.GetKeyDown(KeyCode.W))
		{
		    rb.MovePosition(rb.position + Vector2.up);
        }
		else if (Input.GetKeyDown(KeyCode.S))
		{
			rb.MovePosition(rb.position + Vector2.down);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
		if (col.tag == "Car")
		{
			Frogge.SetActive(false);
			audioPlay.GetComponent<AudioSource>().Play();
			neededScript.AddNewScore();
			GameManager.CurrentScore = 0;
			Invoke("Exit", 3f);
		}
    }

	void Exit()
    {
		SceneManager.LoadScene("OutroScene");
	}
}
