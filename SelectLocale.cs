using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectLocale : MonoBehaviour
{
    [ReadOnly]public LoadLocaleDropdown[] loadLocaleDropdowns;
    [ReadOnly] public LoadLocale[] loadLocaleTxts;
    public Image flagImage;
    public Sprite[] flags;
    public TMP_Dropdown localizeDropDown;
    private int ID;
    private TMP_Dropdown[] tmp_Dropdowns;
    private TextMeshProUGUI[] textMeshProUGUIs;
    private void Awake()
    {
        loadLocaleDropdowns = FindObjectsByType<LoadLocaleDropdown>(FindObjectsSortMode.None);
        loadLocaleTxts = FindObjectsByType<LoadLocale>(FindObjectsSortMode.None);
        ID = PlayerPrefs.GetInt("LocaleKey", 0);
        ChangeLocale(ID);

        localizeDropDown.value = ID;

        flagImage.sprite = flags[ID];
    }

    private void UpdateAllTxt()
    {
        for (int i = 0; i < loadLocaleTxts.Length; i++)
        {
            loadLocaleTxts[i].UpdateText();
        }
    }
    private void UpdateAllDropdowns()
    {
        for(int i = 0; i < loadLocaleDropdowns.Length; i++)
        {
            loadLocaleTxts[i].UpdateText();
        }
    }
    public void ChangeLocale(int localeID)
    {
        ApplyLocale(localeID);
    }

    private void ApplyLocale(int localeID)
    {
        ID = localeID;
        PlayerPrefs.SetInt("LocaleKey", ID);
        flagImage.sprite = flags[ID];
        UpdateAllDropdowns();
        UpdateAllTxt();
    }
}
