using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    //cualquier obheto que tenga este script y tenga activado el trigger, haga que cada vez que se choque con los squares se carge una escena, en este caso, la escena 0, es decir el inicio.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
