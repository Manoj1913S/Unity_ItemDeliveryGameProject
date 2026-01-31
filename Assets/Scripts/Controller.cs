using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{    [SerializeField] float baseSpeed = 5f;  //bump & Boost
     [SerializeField]float boostSpeed = 10f;
     [SerializeField]float rotateSpeed = 100f;
     [SerializeField] float normalSpeed = 5f;  //bump & Boost
     [SerializeField] TMP_Text boostText;



   void  Start ()
    {
        boostText.gameObject.SetActive(false);
    }
    void FixedUpdate()
    {
        float moveAxis = 0f;
        float rotateAxis = 0f;
        if(Keyboard.current.wKey.isPressed)
        {
            moveAxis = 1f;
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            moveAxis = -1f;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            rotateAxis = 1f;
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            rotateAxis = -1f;
        }
        
        float totalMoveAmount = baseSpeed*moveAxis*Time.deltaTime;
        float totalRotationAmount = rotateSpeed*rotateAxis*Time.deltaTime;

        transform.Translate(0,totalMoveAmount,0);
        transform.Rotate(0,0,totalRotationAmount);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Booster"))
        {
            baseSpeed = boostSpeed;
            boostText.gameObject.SetActive(true);
            Destroy(collision.gameObject ,0.1f);
           
        } 
    }
  
   void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Collide"))
        {
            baseSpeed = normalSpeed;
            boostText.gameObject.SetActive(false);
        
        }
         
           
        
    
    }
    
}
