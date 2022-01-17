using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mover : MonoBehaviour
{
    public void LoadScreen(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }
}