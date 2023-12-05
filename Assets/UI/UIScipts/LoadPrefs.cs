using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditorInternal.ReorderableList;

public class LoadPrefs : MonoBehaviour
{
    [SerializeField] private bool canUse = false;
    [SerializeField] private Controls menuController;

    [SerializeField] private TMP_Text VolumeTextValue = null;
    [SerializeField] private Slider VolumeSlider = null;

    [SerializeField] private TMP_Text ControlSenTextValue = null;
    [SerializeField] private Slider ControlSenSlider = null;

    [SerializeField] private Toggle InvertYToggle = null;

    private void Awake()
    {
        if (canUse)
        {
            if (PlayerPrefs.HasKey("masterVolume"))
            {
                float localVolume = PlayerPrefs.GetFloat("masterVolume");
                VolumeTextValue.text = localVolume.ToString("0.0");
                VolumeSlider.value = localVolume;
                AudioListener.volume = localVolume;
            }
            else
            {
                menuController.ResetButton("Audio");
            }
            if (PlayerPrefs.HasKey("masterSen"))
            {
                float localSen = PlayerPrefs.GetFloat("masterSen");

                ControlSenTextValue.text = localSen.ToString("0");
                ControlSenSlider.value = localSen;
                menuController.ControlSen = Mathf.RoundToInt(localSen);
            }
            if (PlayerPrefs.HasKey("masterInvertY"))
            {
                if (PlayerPrefs.GetInt("masterInvertY") == 1)
                {
                    InvertYToggle.isOn = true;
                }
                else
                {
                    InvertYToggle.isOn = false;
                }
            }
        }
    }
}