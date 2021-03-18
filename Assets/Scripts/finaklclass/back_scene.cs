using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_scene : MonoBehaviour
{
    public string scene_name_1;

    public void back()
    {
        SceneManager.LoadScene(scene_name_1);
    }

    public void exit_app()
    {
        Application.Quit();
    }
}
