using UnityEngine;

public class InputReader : MonoBehaviour
{
    public bool GetMouseButtonDown()
    {
        return Input.GetMouseButtonDown(0);
    }
}
