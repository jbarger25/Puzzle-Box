using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject CreditsPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = (false);
#else
        Application.Quit();
#endif
    }

    public void PlayTest()
    {
        Debug.Log("Play Button Pressed");
        SceneManager.LoadScene(1);
    }

    public void OptionsTest()
    {
        Debug.Log("Options Button Pressed");
    }
    public void Credits()
    {
        CreditsPanel.SetActive(true);
    }

    public void ShowScores()
    {
        Debug.Log("This will show the highscores");
    }
    public void Back() 
    {
        CreditsPanel.SetActive(false);    
    }

}
