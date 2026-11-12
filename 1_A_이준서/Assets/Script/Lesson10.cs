using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 5;
        string result = "";
        for (int q = 1; q <= height; q++)
        {
            for(int w = 0; w < q ; w++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

}