using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    [SerializeField] float destroyDelay = 0.1f;
    [SerializeField] Sprite hasPackagebottom;
    [SerializeField] Sprite noPackagebottom;
    //[SerializeField] SpriteRenderer towerSpriteRenderer;
    //[SerializeField] Color32 hasPackageColour = new Color32 (1, 1, 1, 1);
    //[SerializeField] Color32 noPackageColour = new Color32 (1, 1, 1, 1);

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
            Debug.Log("Paczka zabrana.");
            hasPackage = true;
            spriteRenderer.sprite = hasPackagebottom;
            //towerSpriteRenderer.color = hasPackageColour;
            Destroy(other.gameObject, destroyDelay);

            
        }

        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Paczka doręczona!");
            hasPackage = false;
            spriteRenderer.sprite = noPackagebottom;
            //towerSpriteRenderer.color = noPackageColour;
            
        }


            
    }


}
