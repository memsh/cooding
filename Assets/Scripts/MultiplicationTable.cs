using System.Runtime.InteropServices.WindowsRuntime;
using Unity.Collections;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {  
    
        int num = 5;
        string result = "";
          for (int y =1; y <=10; y++)
        {
        result += num + "x" + y + "=" + Multiply(num, y);
        if (y < 10)
        {
            result += " , ";
        }
          
        }
        Debug.Log(result);
    }
    int Multiply(int num1, int num2)
    {
       return num1 * num2;
    }
  
















    // Update is called once per frame
    void Update()
    {
        
    }
}
