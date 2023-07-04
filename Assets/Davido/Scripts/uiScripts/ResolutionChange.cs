using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionChange : MonoBehaviour
{
    [SerializeField] private Dropdown Dropdown;

    private Resolution[] resolutions;  
    private List<Resolution> filteredresolutions;

    private float currentRefreshRate;
    private int currentResolutionIndex = 0;



    private void Start()
    {
        resolutions = Screen.resolutions;
        filteredresolutions = new List<Resolution>();

        Dropdown.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate;


        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].refreshRate == currentRefreshRate)
            {
                filteredresolutions.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();
        for (int i = 0; i < filteredresolutions.Count; i++)
        {
            string resolutionOption = filteredresolutions[i].width + "x" + filteredresolutions[i].height + " " + filteredresolutions[i].refreshRateRatio + " Hz";
            options.Add(resolutionOption);
            if (filteredresolutions[i].width==Screen.width && filteredresolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        Dropdown.AddOptions(options);
        Dropdown.value = currentResolutionIndex;
        Dropdown.RefreshShownValue();




    }


    public void SetResolution(int resolutionIndex)
    {

        Resolution resolution = filteredresolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);

    }



}
