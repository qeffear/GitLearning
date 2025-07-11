using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    private int counter = 0;
    private bool isCounting = false;
    private Coroutine countingCoroutine;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isCounting)
            {
                StopCoroutine(countingCoroutine);
                isCounting = false;
            }
            else
            {
                countingCoroutine = StartCoroutine(CountCoroutine());
                isCounting = true;
            }
        }
    }

    IEnumerator CountCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            counter++;
            Debug.Log("Ñ÷¸ò÷èê: " + counter);
        }
    }
}
