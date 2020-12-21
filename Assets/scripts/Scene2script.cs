using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene2script : MonoBehaviour
{
    public Button scene2next;
    public string addscene3;
    private void Start()
    {
        scene2next.onClick.AddListener(Gotoscene3);
    }

    private void Gotoscene3()
    {
        SceneManager.LoadScene(addscene3);
    }
}