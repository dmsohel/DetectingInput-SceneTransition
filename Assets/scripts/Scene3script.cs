using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene3script : MonoBehaviour
{
    public Button back;
    public string addmaster;
    private void Start() { 
    
        back.onClick.AddListener(GotoMaster);
    }

    private void GotoMaster()
    {
        SceneManager.LoadScene(addmaster);
    }
}
