using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1script : MonoBehaviour
{
    // Start is called before the first frame update
    public Button scene1next;
    public string addscene2;
    private void Start()
    {
        scene1next.onClick.AddListener(Gotoscene2);
    }

    private void Gotoscene2()
    {
        SceneManager.LoadScene(addscene2);
    }
}
