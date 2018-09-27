using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

    private Scene scene;
    [SerializeField]
    Text textLives;

    [SerializeField]
    int lives;

	// Use this for initialization
	void Start ()
    {
        lives = 5;
        scene = SceneManager.GetActiveScene();
    }
	
    void UpdateLives()
    {
        textLives.text = "Liv: " + lives.ToString();
    }
	// Update is called once per frame
	void Update ()
    {
        UpdateLives();
	}

    public void SubtractLives()
    {
        lives -= 1;
        if (lives <= 0)
        {
            Debug.Log("Skift scene");
            //Application.LoadLevel("GameOver");
            SceneManager.LoadScene("GameOver");
        }
    }

    //public void ChangeScene(string name)
    //{
        
        
    //}
}


