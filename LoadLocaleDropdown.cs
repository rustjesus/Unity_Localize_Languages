using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class LoadLocaleDropdown : MonoBehaviour
{
    private string[] english;

    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] french;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] spanish;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] italian;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] port_Brazil;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] port_Portugal;

    [SerializeField] private TMP_Dropdown textMeshProDropDown;

    private void Awake()
    {
        if (textMeshProDropDown == null)
        {
            textMeshProDropDown = GetComponent<TMP_Dropdown>();
        }

        if (textMeshProDropDown != null)
        {
            // Initialize the English array with the same size as the dropdown options count
            english = new string[textMeshProDropDown.options.Count];

            // Copy dropdown options text to the English array
            for (int i = 0; i < textMeshProDropDown.options.Count; i++)
            {
                english[i] = textMeshProDropDown.options[i].text;
            }

            UpdateDropdownTMP();
        }
    }

    public void UpdateDropdownTMP()
    {
        if (textMeshProDropDown == null) return;

        int locale = PlayerPrefs.GetInt("LocaleKey");

        switch (locale)
        {
            case 0: // English
                for (int i = 0; i < english.Length; i++)
                {
                    textMeshProDropDown.options[i].text = english[i];
                }
                break;
            case 1: // French
                for (int i = 0; i < french.Length; i++)
                {
                    textMeshProDropDown.options[i].text = french[i];
                }
                break;
            case 2: // Spanish
                for (int i = 0; i < spanish.Length; i++)
                {
                    textMeshProDropDown.options[i].text = spanish[i];
                }
                break;
            case 3: // Italian
                for (int i = 0; i < italian.Length; i++)
                {
                    textMeshProDropDown.options[i].text = italian[i];
                }
                break;
            case 4: // port brazil
                for (int i = 0; i < italian.Length; i++)
                {
                    textMeshProDropDown.options[i].text = port_Brazil[i];
                }
                break;
            case 5: // port portugal
                for (int i = 0; i < italian.Length; i++)
                {
                    textMeshProDropDown.options[i].text = port_Portugal[i];
                }
                break;
            default:
                Debug.LogWarning("Unknown locale.");
                break;
        }

        // Refresh the dropdown display
        textMeshProDropDown.RefreshShownValue();
    }
}
