using UnityEngine;

public class test : MonoBehaviour
{

    void Update()
    {
        transform.RotateAround(transform.position, transform.up, 2f * Time.deltaTime);
    }
}
