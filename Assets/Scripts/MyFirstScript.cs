using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyFirstScript : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void Back()
    {
        int sceneID = 0;
        SceneManager.LoadScene(sceneID);
    }
}
