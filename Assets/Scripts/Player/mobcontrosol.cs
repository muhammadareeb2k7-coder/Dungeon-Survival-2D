using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobcontrosol : MonoBehaviour
{

    void Awake()
    {
        // PC (Windows, Mac, Linux) pe ye mobile controls hide kar do
        if (!(Application.platform == RuntimePlatform.Android ||
              Application.platform == RuntimePlatform.IPhonePlayer))
        {
            gameObject.SetActive(false); // Mobile controls canvas / buttons hide ho jaayenge
        }
    }
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
