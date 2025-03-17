using UnityEngine;

public class FunctionReturnValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int r = SquareFunction(6);
        Debug.Log(r);
    }
    int SquareFunction(int x)
    {
        int r = x * x;
        return r;
    }

}
