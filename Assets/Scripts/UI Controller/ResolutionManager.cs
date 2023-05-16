using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    [SerializeField] TMP_Dropdown resolutionDropdown;

    Resolution[] resolutions;
    List<Resolution> filteredResolution;

    float currentRefreshRate; 
    int currentResolutionIndex = 0;

    void Start()
    {
        resolutions = Screen.resolutions; // Ambil data Resolution dari Screen System Resolution
        filteredResolution = new List<Resolution>();

        resolutionDropdown.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate; // Ambil data Refresh Rate dari Screen System Resolution

        Screen.fullScreen = true;

        for (int i = 0; i < resolutions.Length; i++) 
        {
            if (resolutions[i].refreshRate == currentRefreshRate) // Ambil kondisi dimana Refresh Rate System sama dengan Refre
            {
                filteredResolution.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();
        for (int i = 0;i < filteredResolution.Count; i++) 
        {
            string resolutionOption = $"{filteredResolution[i].width} x {filteredResolution[i].height}";
            options.Add(resolutionOption);
            if (filteredResolution[i].width == Screen.width && filteredResolution[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = filteredResolution[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullScreen(bool value) 
    {
        Screen.fullScreen = value;
    }
}
