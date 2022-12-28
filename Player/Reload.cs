using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    bool _isActive;

    private void Start()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
    private void Update()
    {
        if (_isActive)
        {
            SceneManager.LoadScene(1);          
        }   
    }

    public void PointerDown()
    {
        _isActive = true;
    }

    public void PointerUp()
    {
        _isActive = false;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
