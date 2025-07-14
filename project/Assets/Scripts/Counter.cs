using UnityEngine;
using System;
using System.Collections;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    private int _value;
    private float _delay = 0.5f;
    private bool _isValue;
    private Coroutine _countingRoutine;
    private WaitForSeconds _waitDelay;
    
    public event Action<int> ValueChanged;

    private void Awake()
    {
        _waitDelay = new WaitForSeconds(_delay);
    }

    private void OnEnable()
    {
        _inputReader.Clicked += ToggleValue;
    }

    private void OnDisable()
    {
        _inputReader.Clicked -= ToggleValue;
    }

    private void ToggleValue()
    {
        if (_isValue)
        {
            StopValue();
        }
        else
        {
            StartValue();
        }
    }

    private void StartValue()
    {
        _countingRoutine = StartCoroutine(Numbering());
        _isValue = true;
    }

    private void StopValue()
    {
        if (_countingRoutine != null)
        {
            StopCoroutine(_countingRoutine);
        }

        _isValue = false;
    }

    private IEnumerator Numbering()
    {
        while (enabled)
        {
            yield return _waitDelay;
            _value++;
            ValueChanged?.Invoke(_value);
        }
    }
}
