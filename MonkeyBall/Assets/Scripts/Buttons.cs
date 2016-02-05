using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Buttons : MonoBehaviour {
    
	public void _BtnQuitGame()
    {
        Application.Quit();
    }

    public void _BtnNextLevel(int curLevel)
    {
        switch (curLevel)
        {
            case 1:
                SceneManager.LoadScene("LevelTwo");
                break;
            case 2:
                SceneManager.LoadScene("LevelThree");
                break;
            case 3:
                SceneManager.LoadScene("LevelFour");
                break;
            case 4:
                SceneManager.LoadScene("LevelFive");
                break;
            case 5:
                SceneManager.LoadScene("LevelSelect");
                break;
        }
    }

    public void  _BtnSelectLevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void _BtnRestartLevel()
    {

    }

    public void _BtnHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void _BtnStore()
    {
        SceneManager.LoadScene("Store");
    }

    public void _BtnCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void _BtnLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void _BtnLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void _BtnLevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }

    public void _BtnLevelFour()
    {
        SceneManager.LoadScene("LevelFour");
    }

    public void _BtnLevelFive()
    {
        SceneManager.LoadScene("LevelFive");
    }
}
