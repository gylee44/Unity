using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "��";
        tom.sound = "�Ŀ�!";
        
        Animal jerry = new Animal();
        jerry.name = "����";
        jerry.sound = "����!";

        jerry = tom;
        jerry.name = "��Ű";
        //jerry�� tom�� ����Ű�� ��ü�� ����Ű�� �� (�����X)
        //jerry�� ó���� ����Ű�� Animal ��ü�� �̾� -> �������� �ı�

        tom.PlaySound();
        jerry.PlaySound();
    }
}
