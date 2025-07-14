using UnityEngine;
using System.Collections;
using System;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    private int _counter = 0;
    private float _delay = 0.5f;
    private bool _isCounting = false;
    private Coroutine _countingCoroutine;

    public event Action<int> CounterChanged;

    private void OnEnable()
    {
        _inputReader.Clicked += ToggleCounting;
    }

    private void OnDisable()
    {
        _inputReader.Clicked -= ToggleCounting;
    }

    private void ToggleCounting()
    {
        if (_isCounting)
        {
            StopCounting();
        }
        else
        {
            StartCounting();
        }
    }

    private void StartCounting()
    {
        _countingCoroutine = StartCoroutine(CountRoutine());
        _isCounting = true;
    }

    private void StopCounting()
    {
        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);
        }
        _isCounting = false;
    }

    private IEnumerator CountRoutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_delay);
            _counter++;
            CounterChanged?.Invoke(_counter);
            Debug.Log(_counter);
        }
    }
}
