using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class RayCast_ReturnTop : MonoBehaviour
{ 
    public float actionChangeTime = 3f;
    float timer;
    bool eyeEnter;
    bool flag = false;


    // Start is called before the first frame update
    void Start()
    {
        timer = actionChangeTime;
        eyeEnter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (eyeEnter)
        {
            timer -= Time.fixedDeltaTime;
            if(timer < 0)
            {
                timer = actionChangeTime;
                flag = true;
                //XRSettings.enabled = false;
                //VRSettings.enabled = !VRSettings.enabled;
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EnterToTarget()
    {
        eyeEnter = true;
    }

    public void OutToTarget()
    {
        eyeEnter = false;
        flag  = false;
        timer = actionChangeTime;
    }
}
