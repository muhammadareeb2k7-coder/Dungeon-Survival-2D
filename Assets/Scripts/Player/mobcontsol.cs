using UnityEngine;

public class MobileControlsHandler : MonoBehaviour
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
}
