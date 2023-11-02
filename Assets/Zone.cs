using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Zone : PressurePlate
{
    public UnityEvent<string> onMesageZone;
    

    protected override void Execute()
    {
        base.Execute();
        onMesageZone?.Invoke(message);
    }

  
}
