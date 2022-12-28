using System.Collections;
using UnityEngine;


public class SetPanelActive : MonoBehaviour
{  
    [SerializeField] private AudioSource _disableSceneMusic;

    private void Start()
    {
        _disableSceneMusic.Stop();
        StartCoroutine(LosePanel());
    }
 
    IEnumerator LosePanel()
    {
        yield return new WaitForSeconds(6.5f);
        Time.timeScale = 0;
        AudioListener.pause = true;
    }
}
