using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class Controls : MonoBehaviour
{
    [SerializeField] private TMP_Text VolumeTextValue = null;
    [SerializeField] private Slider VolumeSlider = null;
    [SerializeField] private float DefaultVolume = 1.0f;

    [SerializeField] private TMP_Text ControlSenTextValue = null;
    [SerializeField] private Slider ControlSenSlider = null;
    [SerializeField] private int DefaultSen = 4;
    public int ControlSen = 4;

    [SerializeField] private Toggle InvertYToggle = null;

    [SerializeField] private GameObject confirmationPrompt = null;

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        VolumeTextValue.text = volume.ToString("0.0");
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
    }

    public void SetControllerSen(float Sensitivity)
    {
        ControlSen = Mathf.RoundToInt(Sensitivity);
        ControlSenTextValue.text = Sensitivity.ToString("0");
    }

    public void GameApply()
    {
        if (InvertYToggle.isOn)
        {
            PlayerPrefs.SetInt("masterInvertY", 1);
        }
        else
        {
            PlayerPrefs.SetInt("masterInvertY", 0);
        }

        PlayerPrefs.SetFloat("masterSen", ControlSen);
        StartCoroutine(ConfirmationBox());
    }
    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            AudioListener.volume = DefaultVolume;
            VolumeSlider.value = DefaultVolume;
            VolumeTextValue.text = DefaultVolume.ToString("0.0");
            VolumeApply();
        }

        if (MenuType == "GamePlay")
        {
            ControlSenTextValue.text = DefaultSen.ToString("0");
            ControlSenSlider.value = DefaultSen;
            ControlSen = DefaultSen;
            InvertYToggle.isOn = false;
            GameApply();
        }
    }
    public IEnumerator ConfirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
