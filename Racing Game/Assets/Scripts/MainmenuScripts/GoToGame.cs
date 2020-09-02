using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("First");
    }
    public void AppQuit () {
		Application.Quit ();
	}
}
