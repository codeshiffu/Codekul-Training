using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene : MonoBehaviour
{
    public string scene_name;

    public void next()
    {
        SceneManager.LoadScene(scene_name);
    }

    public void exit_my_app()
    {
        Application.Quit();
    }
}
