using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UIController : MonoBehaviour {

    public Text TextVictory;
    public Text TextDefeat;

    public Button BtnRestart;
    public Button BtnNextLevel;

    public GameObject EndLevelPanel;

    public bool resetValues = false;
    public bool hasWon = false;
    public bool hasLost = false;

    public Text timer;
    public float timeLimit = 60f;

    private bool countDown = true;

    void Update()
    {
        if (countDown)
        {
            timeLimit -= Time.deltaTime;
            timer.text = timeLimit.ToString("0.00");
        }

        if (timeLimit <= 0f)
        {
            EndLevelDefeat();
            timer.gameObject.SetActive(false);
            countDown = false;
        }
    }

    public void EndLevelVictory()
    {
        EndLevelPanel.SetActive(true);
        TextVictory.gameObject.SetActive(true);
        BtnNextLevel.gameObject.SetActive(true);
    }

    public void EndLevelDefeat()
    {
        EndLevelPanel.SetActive(true);
        TextDefeat.gameObject.SetActive(true);
        BtnRestart.gameObject.SetActive(true);
    }

    public void ResetValues()
    {
        TextDefeat.gameObject.SetActive(false);
        BtnRestart.gameObject.SetActive(false);
        TextVictory.gameObject.SetActive(false);
        BtnNextLevel.gameObject.SetActive(false);
        EndLevelPanel.SetActive(false);
    }
}
