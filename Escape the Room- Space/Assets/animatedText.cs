using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class animatedText : MonoBehaviour {

    public string writtenText;
    private string defaultString = "";


	// Use this for initialization
	void Start () {
        StartCoroutine(updateText());
	}
	
	IEnumerator updateText()
    {
        for (int i = 0; i < writtenText.Length; i++)
        {
            defaultString = writtenText;
            this.GetComponent<Text>().text = defaultString.Substring(0, i);
            yield return new WaitForSeconds(0.25f);
        }
    }
}
