using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    //Bu kodu oyun karakterinize baglarsaniz karakterin 4 ana yöne hareket edebilmesini saglarsiniz
    private float speed = 10;
    void Start()
    {
        
    }

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        x *= Time.deltaTime * speed;
        y *= Time.deltaTime * speed;
        transform.Translate(x, 0f, y);
    }
}
