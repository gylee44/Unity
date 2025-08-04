using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "냐옹!";
        
        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "찍찍!";

        jerry = tom;
        jerry.name = "미키";
        //jerry도 tom이 가리키는 객체를 가리키게 됨 (덮어쓰기X)
        //jerry가 처음에 가리키던 Animal 객체는 미아 -> 가비지가 파괴

        tom.PlaySound();
        jerry.PlaySound();
    }
}
