using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public void buttonPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void buttonOptions()
    {
        SceneManager.LoadScene("optionsMenu");
    }
}
