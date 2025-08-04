using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start(){
        /* float distance = GetDistance(2,2,5,6);
         Debug.Log("(2,2)에서 (5,6)까지의 거리: " +  distance);*/

        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i+"번 학생의 점수: " + students[i]);
        }
    }

   /* float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);    //루트

        return distance;
    }*/
}
