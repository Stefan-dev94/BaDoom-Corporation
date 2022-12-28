using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceFromPlayer : MonoBehaviour
{
    [SerializeField] private Transform _checkPoint;
    [SerializeField] private Text _distanceText;
    [SerializeField] private Text _dispayDistanceText;
    [SerializeField] private Text _hightScore;
    [SerializeField] private float _distance = 0f;

    private void Start()
    {
        _hightScore.text = "Рекорд: " + PlayerPrefs.GetFloat("HightScore", 0).ToString("F1")+"M";
    }

    private void Update()
    {
        _distance = (_checkPoint.transform.position - transform.position).magnitude;
        _distanceText.text = "Вы пролетели: " + _distance.ToString("F1") + "M";
        _dispayDistanceText.text = "Вы пролетели:" + _distance.ToString("F1") + "M";

        HighScore();
    }
    public void HighScore()
    {
        if (_distance > PlayerPrefs.GetFloat("HightScore", 0))
        {
            PlayerPrefs.SetFloat("HightScore", _distance);
            _hightScore.text ="Рекорд: "+ _distance.ToString("F1");
        }
    }
}
