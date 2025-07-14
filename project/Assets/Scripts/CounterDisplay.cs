using UnityEngine;

public class CounterDisplay : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    public void ShowCount(int count)
    {
        Debug.Log("Ñ÷¸ò÷èê: " + count);
    }
}
