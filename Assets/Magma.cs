using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma : Interactable
{
  
    
    public override void Interact(PlayerController player)
    {
       player.GetDamage();
       Debug.Log(message);

    }
}
