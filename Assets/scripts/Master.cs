using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Master : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public Button button1;
    public Button button2;
    public Button button3;
    public string sceneno1;
    public string sceneno2;
    public string sceneno3;

    private void Start()
    {
        button1.onClick.AddListener(OnButtonClick);
        button2.onClick.AddListener(OnbuttonClick);
        button3.onClick.AddListener(Onbuttonclick);

    }
    private void OnButtonClick()
    {
        Debug.Log("button1 is pressed");
        SceneManager.LoadScene(sceneno1);
    }
    private void OnbuttonClick()
    {
        Debug.Log("button2 is pressed");
        SceneManager.LoadScene(sceneno2);
    }
    private void Onbuttonclick()
    {
        Debug.Log("button3 is pressed");
        SceneManager.LoadScene(sceneno3);
    }
    // Update is called once per frame
}



