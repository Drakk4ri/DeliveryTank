using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTurning : MonoBehaviour
{
    
    void Update()
    {
        TurnTower();
    }

    void TurnTower()
    {
       
        int addAngle = 90;
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - addAngle, Vector3.forward);
        
    }



}

