using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    //Master audio
    [SerializeField] private AudioMixer master;

    //Text that appears on fullscreen button
    [SerializeField] private Text fullScreenText;

    //Resolution dropdown
    [SerializeField] private Dropdown resolutionDropDown;

    //Array containing resolutions
    Resolution[] resolutions;

    //On start, resolutions are set to all avaliable screen resolutions
    private void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropDown.ClearOptions();

        List<string> options = new List<string>();

        int currentResIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width  + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResIndex = i;
            }
        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResIndex;
        resolutionDropDown.RefreshShownValue();
    }

    //Sets the volume level
    public void SetVolume(float volume)
    {
        master.SetFloat("MasterVolume", volume);
    }

    //Sets the quality level
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    //Determines if fullscreen is active or not
    public void SetFullScreen(bool isScreenFull)
    {
        Screen.fullScreen = isScreenFull;

        //Changes the text, depending on if the screen is full or not
        if(isScreenFull == true)
        {
            fullScreenText.text = "ON";
        }
        else
        {
            fullScreenText.text = "OFF";
        }
    }

    //Sets the screen resolution
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}

