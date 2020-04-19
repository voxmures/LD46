using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum MainMenuState
{
    IDLE = 0,
    INTRO = 1,
    DONE = 2
}

public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI gameTitle;
    public TextMeshProUGUI pressStart;

    private float m_Time = 0f;
    private MainMenuState m_State = MainMenuState.IDLE;

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        if (m_State == MainMenuState.IDLE)
        {
            m_Time += dt * 2.5f;

            pressStart.alpha = Mathf.Cos(m_Time);

            if (Input.anyKeyDown)
            {
                // TODO: Do the story animation
                m_State = MainMenuState.INTRO;
            }
        }
        else if (m_State == MainMenuState.INTRO)
        {
            // Fade out both GameTitle and PressStart
            gameTitle.alpha -= 1f * dt;
            pressStart.alpha -= 1f * dt;

            if (gameTitle.alpha <= 0)
            {
                m_State = MainMenuState.DONE;
            }
        }
        else if (m_State == MainMenuState.DONE)
        {
            GoToGame();
        }
    }

    private void GoToGame()
    {
        SceneManager.LoadScene("Level_0");
    }
}
