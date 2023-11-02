using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate :Interactable
{
    public static System.Action<string> onInteract;
    
    protected virtual void Execute()
    {
        onInteract?.Invoke(message);
    }
    public override void Interact(PlayerController player)
    {
        Execute();
    }
}
