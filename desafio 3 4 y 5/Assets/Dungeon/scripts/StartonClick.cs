using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOnClick : MonoBehaviour
{
    // Este método se llamará cuando se haga clic en el botón
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}