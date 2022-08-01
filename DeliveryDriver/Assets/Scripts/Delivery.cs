using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    [SerializeField] float destroyDelay = 0.1f;
    [SerializeField] Sprite hasPackagebottom;
    [SerializeField] Sprite noPackagebottom;
    

    public static bool hasPackage;

    SpriteRenderer spriteRenderer;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
           
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.sprite = hasPackagebottom;
            
            Destroy(other.gameObject, destroyDelay);

        }

        if (other.tag == "Customer" && hasPackage == true)
        {
            hasPackage = false;
            spriteRenderer.sprite = noPackagebottom;
            PointSystem.instance.AddPoint();
        }

        

            
    }


}
