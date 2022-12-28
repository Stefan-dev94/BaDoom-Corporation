using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    [SerializeField] private Transform _checkPoint;
    [SerializeField] private Text _yourDistanceText;
    [SerializeField] private float _distance = 0f;

    private void Update()
    {
        _distance = (_checkPoint.transform.position - transform.position).magnitude;
        _yourDistanceText.text = "You distance: " + _distance.ToString("F1") + "M";
    }
}
