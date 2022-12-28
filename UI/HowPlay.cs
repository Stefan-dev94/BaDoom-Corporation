using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowPlay : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    
    public void HowPlayPanel()
    {
        _panel.SetActive(true);
    }

    public void ExitPanel()
    {
        _panel.SetActive(false);
    }
}
