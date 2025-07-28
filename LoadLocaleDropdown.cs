using System.Collections;
using System.Collections.Generic;
using Michsky.MUIP;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class LoadLocaleDropdown : MonoBehaviour
{
    private string[] english;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] french;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] spanish;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(2, 20)] public string[] italian;
    private TMP_Dropdown textMeshProDropDown;
    private CustomDropdown customDropDown;
    private void Awake()
    {
        if(GetComponent<TMP_Dropdown>() != null)
        {

            textMeshProDropDown = GetComponent<TMP_Dropdown>();
        }

        if(GetComponent<CustomDropdown>() != null)
        {
            customDropDown = GetComponent<CustomDropdown>();

        }
        if (textMeshProDropDown != null)
        {
            // Initialize the english array with the same size as the dropdown options count
            english = new string[textMeshProDropDown.options.Count];

            // Copy dropdown options text to the english array
            for (int i = 0; i < textMeshProDropDown.options.Count; i++)
            {
                english[i] = textMeshProDropDown.options[i].text;
            }

            UpdateDropdownTMP();
        }
        if (customDropDown != null)
        {
            // Initialize the english array with the same size as the dropdown options count
            english = new string[customDropDown.items.Count];

            // Copy dropdown options text to the english array
            for (int i = 0; i < customDropDown.items.Count; i++)
            {
                english[i] = customDropDown.items[i].itemName;
            }

            UpdateDropdownCustom();
        }
    }
    public void UpdateDropdownCustom()
    {
        if (customDropDown == null) return;

        int locale = PlayerPrefs.GetInt("LocaleKey");

        switch (locale)
        {
            case 0: // English
                for (int i = 0; i < english.Length; i++)
                {
                    customDropDown.items[i].itemName = english[i];
                }
                break;
            case 1: // French
                for (int i = 0; i < french.Length; i++)
                {
                    customDropDown.items[i].itemName = french[i];
                }
                break;
            case 2: // Spanish
                for (int i = 0; i < spanish.Length; i++)
                {
                    customDropDown.items[i].itemName = spanish[i];
                }
                break;
            case 3: //Italian
                for (int i = 0; i < italian.Length; i++)
                {
                    customDropDown.items[i].itemName = italian[i];
                }
                break;
            default:
                Debug.LogWarning("Unknown locale.");
                break;
        }

        // Refresh the dropdown display
        customDropDown.RefreshShownValue();
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
            case 3: //Italian
                for (int i = 0; i < italian.Length; i++)
                {
                    textMeshProDropDown.options[i].text = italian[i];
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
