using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOnClick : MonoBehaviour
{
    // Este m�todo se llamar� cuando se haga clic en el bot�n
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}