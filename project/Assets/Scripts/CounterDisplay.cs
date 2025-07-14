using UnityEngine;

public class CounterDisplay : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.CounterChanged += ShowCount;
    }

    private void OnDisable()
    {
        _counter.CounterChanged -= ShowCount;
    }

    public void ShowCount(int count)
    {
        Debug.Log("Ñ÷¸ò÷èê: " + count);
    }
}
