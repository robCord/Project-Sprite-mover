using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDisabler : MonoBehaviour
{
    public GameObject spriteToDisable;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            spriteToDisable.SetActive(!spriteToDisable.activeInHierarchy);
        }
    }
}
