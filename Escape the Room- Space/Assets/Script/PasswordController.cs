using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasswordController : MonoBehaviour {
    [SerializeField]
    private timer oxygenT;

    public InputField[] inputs = new InputField[6];

    [SerializeField]
    private string[] passwords = new string[6];

    [SerializeField]
    private GameObject[] hintWindows;

    [SerializeField]
    private GameObject[] passwordWindows;

    public string[] inputStrings = new string[6];

    private int passwordIndex;

    // Use this for initialization
    private void Awake()
    {
        
    }
    void Start () {
        passwordIndex = 0;


        for (int k = 0; k < 5; k++)
        {
            hintWindows[k].gameObject.SetActive(false);
        }
        
	}

    public void checkPassword(int passcodeNumber)
    {
        for (int i = 0; i < inputs.Length; i++)
        {
            inputStrings[i] = inputs[i].text;
        }

        if (inputStrings[passcodeNumber] != null)
        {

            if (inputStrings[passcodeNumber] == passwords[passcodeNumber])
            {
                if (passcodeNumber >= 5)
                {
                    SceneManager.LoadScene(2);
                }
                else
                {
                    //  힌트주는창 appear
                    Debug.Log("password passed");
                    passwordWindows[passcodeNumber].SetActive(false);
                    passwordWindows[passcodeNumber].SetActive(true);
                    inputs[passcodeNumber].gameObject.SetActive(false);
                    hintWindows[passcodeNumber].SetActive(true);
                    oxygenT.updateOxygen(oxygenT.addOxygen());
                   // t.updateOxygen(t.addOxygen());
                    // audio sound or particle effect
                }
            }
            else
            {
                Debug.Log(inputStrings[passcodeNumber] + ", " + passwords[passcodeNumber]);
                Debug.Log("Wrong" + passcodeNumber);
                inputs[passcodeNumber].text = "";
            }
        }

    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
