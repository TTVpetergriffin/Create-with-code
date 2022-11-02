using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    public int[] LottoNumbers = { 1, 2, 3, 4, 5, 6 };
    public int myNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myNumber = LottoNumbers[Random.Range(1, 5)];
        Debug.Log("My Lotto Number is: " + myNumber);
    }
}
