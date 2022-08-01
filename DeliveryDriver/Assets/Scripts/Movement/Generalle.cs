using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class Generalle : MonoBehaviour
{

    [SerializeField] Sprite hasPackageSprite;
    [SerializeField] Sprite hasNoPackageSprite;  

    SpriteRenderer spriteRenderer;
    [SerializeField] int delayTime;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    async void OnTriggerEnter2D(Collider2D other) 
    {
            if (other.tag == "Tank") //&& Delivery.hasPackage == true)
        {
            Debug.Log("Paczka dowieziona!");
            spriteRenderer.sprite = hasPackageSprite;
            await Task.Delay(delayTime);
            spriteRenderer.sprite = hasNoPackageSprite;

            //Thread.Sleep(delayTime);
        }
           
    }

    
}
