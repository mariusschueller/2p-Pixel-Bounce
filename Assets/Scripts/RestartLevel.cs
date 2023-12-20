using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void redo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

