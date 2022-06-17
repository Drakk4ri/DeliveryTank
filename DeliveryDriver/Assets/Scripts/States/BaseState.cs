using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState
{
    public virtual void Enter() { }
    public virtual void UpdateLogic() { }
   
    public virtual void Exit() { }  

}
