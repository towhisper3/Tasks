using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Play()
    {
      GameObject.Find("Canvas/mainMenu/UI").SetActive(false);
      GameObject.Find("Canvas/mainMenu/Select").SetActive(true);
    }
    public void Quit()//ÍË³öÓÎÏ·
    {
        Application.Quit();
    }
    public void UIenable()
    {
        GameObject.Find("Canvas/mainMenu/UI").SetActive(true);
    }
    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Pause()
    {
        GameObject.Find("UI/Pause/Panel").SetActive(true);
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        GameObject.Find("UI/Pause/Panel").SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
