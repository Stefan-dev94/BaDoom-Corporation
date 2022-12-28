using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSound : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
}
