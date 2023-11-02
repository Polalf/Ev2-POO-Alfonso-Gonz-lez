using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        PressurePlate.onInteract += ShowMesage;
    }
    private void OnDisable()
    {
        PressurePlate.onInteract -= ShowMesage;
    }

    public void ShowMesage(string _mesage)
    {
        Debug.Log(_mesage);
    }
}
