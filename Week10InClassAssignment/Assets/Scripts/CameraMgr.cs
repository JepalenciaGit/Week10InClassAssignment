using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMgr : MonoBehaviour
{
    public Camera MainCamera;
    public Camera PictureInPic;
    public Camera SideViewCamera;
    public Camera SplitScreenUpper;
    public Camera SplitScreenLower;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            Vector3 diff = Vector3.forward * Input.mouseScrollDelta.y;

            if (mainCamera.enabled)
                mainCamera.transform.Translate(diff);

            else if (SideViewCamera.enabled)
                SideViewCamera.transform.Translate(diff);

            else if (SplitScreenLower.enabled)
                SplitScreenLower.transform.Translate(diff);
        }
    }
    public void OnSliderValueChanged(float value)
    {
        Debug.LogFormat("Slider:{0}", value);
        // Code will go here
    }

    public void SwitchViews(Dropdown change)
    {
        Debug.LogFormat("{0}:{1}", change.itemText.text,
            change.value);
        // Code will go here

    }


}
