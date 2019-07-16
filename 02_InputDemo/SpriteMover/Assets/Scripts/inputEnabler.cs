using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputEnabler : MonoBehaviour
{
    public InputHandler handler;
    // Start is called before the first frame update
    void Start()
    {
        handler = GetComponent<InputHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            handler.enabled = !handler.enabled;
        }
    }
}
