using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public Button b1;
    public string scene;

    private void Start()
    {
        b1.onClick.AddListener(OnClickButton);
    }

  private void OnClickButton()
    {
        SceneManager.LoadScene(scene);
    }
    
}
