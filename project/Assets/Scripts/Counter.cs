using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    private int _counter = 0;
    private float _delay = 0.5f;
    private bool _isCounting = false;
    private Coroutine _countingCoroutine;
    private InputReader _inputReader;
    private CounterDisplay _display;

    private void Awake()
    {
        _inputReader = new InputReader();
        _display = new CounterDisplay();
    }

    private void Update()
    {
        if (_inputReader.GetMouseButtonDown())
        {
            ToggleCounting();
        }
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
            _display.ShowCount(_counter);
        }
    }
}
