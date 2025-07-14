using UnityEngine;

public class CounterDisplay : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.Changed += ShowCount;
    }

    private void OnDisable()
    {
        _counter.Changed -= ShowCount;
    }

    public void ShowCount(int count)
    {
        Debug.Log("Ñ÷¸ò÷èê: " + count);
    }
}
