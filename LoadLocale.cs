using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;
public class LoadLocale : MonoBehaviour
{
    private string english;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string french;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string spanish;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string italian;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string port_Brazil;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string port_Portugal;
    private TextMeshProUGUI textMeshProUGUItxt;
    private Text regTxt;
    private void Awake()
    {
        if (GetComponent<Text>() != null)
        {
            regTxt = GetComponent<Text>();
            english = regTxt.text;
        }
        if(GetComponent<TextMeshProUGUI>() != null)
        {
            textMeshProUGUItxt = GetComponent<TextMeshProUGUI>();
            english = textMeshProUGUItxt.text;
        }

        UpdateText();
    }
    public void UpdateText()
    {
        //SET LOCALE TEXT MODE
        //ENGLISH
        if (PlayerPrefs.GetInt("LocaleKey") == 0)
        {
            if(regTxt != null)
                regTxt.text = english;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = english;

        }
        //FRENCH
        if (PlayerPrefs.GetInt("LocaleKey") == 1)
        {
            if (regTxt != null)
                regTxt.text = french;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = french;

        }
        //SPANISH
        if (PlayerPrefs.GetInt("LocaleKey") == 2)
        {
            if (regTxt != null)
                regTxt.text = spanish;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = spanish;

        }
        //ITALIAN
        if (PlayerPrefs.GetInt("LocaleKey") == 3)
        {
            if (regTxt != null)
                regTxt.text = italian;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = italian;

        }
        //port brazil
        if (PlayerPrefs.GetInt("LocaleKey") == 4)
        {
            if (regTxt != null)
                regTxt.text = port_Brazil;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = port_Brazil;

        }
        //port portugal
        if (PlayerPrefs.GetInt("LocaleKey") == 5)
        {
            if (regTxt != null)
                regTxt.text = port_Portugal;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = port_Portugal;

        }

    }
}
