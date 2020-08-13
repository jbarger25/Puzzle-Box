using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    bool pauseTime = false;
    public GameObject MainCube;
    public GameObject pauseScreen;
    public GameObject HUD;
    public GameObject Win_panel;
    public GameObject NextButton;
    public Text FinishedText;
    public Text Puzzles_text;
    public Text timeText;
    public Text HighscoreText;
    float time = 0.0f;
    float scoretime = 100.0f;
    public float puzzles_solved = 0.0f;
    int SceneNum;
    private void Start()
    {
        SceneNum = SceneManager.GetActiveScene().buildIndex;
        print(SceneManager.sceneCountInBuildSettings.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseTime)
        {
            time += Time.deltaTime;
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("escape"))
        {
            Pause();
        }
        Puzzles_text.text = "Puzzels Solved: " + puzzles_solved.ToString("0");
        timeText.text = "Time: " + time.ToString("0.0");
        HighscoreText.text = "Best Time: " +scoretime.ToString("0.0");
        if (scoretime >= time)
            timeText.color = Color.green;
        if (scoretime < time)
            timeText.color = Color.red;
        if (puzzles_solved > 4)
        {
            if (SceneNum < (SceneManager.sceneCountInBuildSettings - 1))
                NextButton.SetActive(true);
            pauseTime = true;
            Win_panel.SetActive(true);
            FinishedText.text = "You Finished The Puzzles in " + time.ToString("0.0") + " Seconds";
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = (false);
#else
        Application.Quit();
#endif
    }
    void Pause()
    {
        if (!pauseTime)
        {
            MainCube.GetComponent<RotateObject>().enabled = false;
            pauseScreen.SetActive(true);
            pauseTime = true;
        }
    }
    public void Resume()
    {
        MainCube.GetComponent<RotateObject>().enabled = true;
        pauseScreen.SetActive(false);
        pauseTime = false;
    }
    public void Load()
    {
        SceneManager.LoadScene(0);
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneNum);
    }
    public void Nextlevel() 
    {
        SceneManager.LoadScene(SceneNum + 1);
    }
}