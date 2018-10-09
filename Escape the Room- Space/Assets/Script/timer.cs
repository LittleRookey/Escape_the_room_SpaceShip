using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

    public GameController gameControl;

    public static timer t;

    private int oxygenLeft; 

    public Text countdownText;

    public Text fiftyText;

    private void Awake()
    {
        oxygenLeft = 100;
        fiftyText.text = "";
        t = this;
    }
    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ": " + (oxygenLeft.ToString() + "%");
        if(oxygenLeft == 50)
        {
            fiftyText.text = "Turn off the light";
        }
        if(oxygenLeft == 48)
        {
            fiftyText.text = "";
        }
        if ( oxygenLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Over";
            SceneManager.LoadScene(3);
        }
    }

    public void updateOxygen(int percent)
    {
        oxygenLeft = percent;
        countdownText.text = ": " + oxygenLeft.ToString() + "%";
    }
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(15);
            oxygenLeft--;
        }
    }

    public int addOxygen()
    {
        return oxygenLeft += 20;
    }



}
