using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    int[] arrayNumber = new int[5] { 1,2,3,4,5};
    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;
    [SerializeField]
    private int number5 = 5;
    List<int> listNumber = new List<int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        //Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        //Debug.Log($"Array의 다섯번째 값 : {arrayNumber[4]}");
        //listNumber.Add(1);
        //listNumber.Add(2);
        //listNumber.Add(3);
        //listNumber.Add(4);
        //listNumber.Add(5);

        //Debug.Log($"ListNumber의 길이 : {listNumber.Count}");
        //Debug.Log($"ListNumber 마지막 데이터 : {listNumber[listNumber.Count - 1]}");
        
    
    }



}
