using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void StarGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
