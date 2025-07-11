using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    private int _counter = 0;
    private float _count = 0.5f;
    private bool _isCounting = false;
    private Coroutine _countingCoroutine;
    private InputReader _inputReader = new InputReader();
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopCoroutine(_countingCoroutine);
                _isCounting = false;
            }
            else
            {
                _countingCoroutine = StartCoroutine(_inputReader.CountCoroutine(_counter, _count));
                _isCounting = true;
            }
        }
    }
}

class InputReader
{
    public IEnumerator CountCoroutine(int counter, float _count)
    {
        while (true)
        {
            yield return new WaitForSeconds(_count);
            counter++;
            Debug.Log("Ñ÷¸ò÷èê: " + counter);
        }
    }
}
