using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage;
 [SerializeField] float delay =0.5f;
    
    void OnTriggerEnter2D(Collider2D collision) {
         if(collision.CompareTag("Package") && hasPackage ==false){
         Debug.Log("Item Pickup");
         hasPackage = true;
         //Item pickup then particle effect on 
         GetComponent<ParticleSystem>().Play();
         //Destroy
         Destroy(collision.gameObject,delay);
         
         }
         if(collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Item Delivered into Customer");
            hasPackage =false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
}
