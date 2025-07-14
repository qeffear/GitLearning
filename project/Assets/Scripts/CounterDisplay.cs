using UnityEngine;

public class CounterDisplay : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.ValueChanged += ShowCount;
    }

    private void OnDisable()
    {
        _counter.ValueChanged -= ShowCount;
    }

    public void ShowCount(int count)
    {
        Debug.Log("Ñ÷¸ò÷èê: " + count);
    }
}
