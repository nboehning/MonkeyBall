using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinVolume : MonoBehaviour {

    public GameObject victoryText;
    public GameObject outOfTimeText;

    public Text timer;
    public float timeLimit = 60f;

    private bool countDown = true;

    UIController UIControlScript;

    public void Start()
    {
        UIControlScript = GameObject.Find("UIController").GetComponent<UIController>();
    }

    void Update()
    {
        if(countDown)
        {
            timeLimit -= Time.deltaTime;
            timer.text = timeLimit.ToString("0.00");
        }

        if(timeLimit <= 0f)
        {
            UIControlScript.EndLevelDefeat();
            timer.gameObject.SetActive(false);
            countDown = false;
        }
    }

	void OnTriggerEnter(Collider other)
    {
        UIControlScript.EndLevelVictory();

        other.attachedRigidbody.isKinematic = true;
        countDown = false;
    }
}
