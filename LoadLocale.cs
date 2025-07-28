using System.Collections;
using System.Collections.Generic;
using Michsky.MUIP;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadLocale : MonoBehaviour
{
    private string english;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string french;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string spanish;
    [ListDrawerSettings(ShowIndexLabels = true)][TextArea(5, 20)] public string italian;
    private TextMeshProUGUI textMeshProUGUItxt;
    private Text regTxt;
    private ButtonManager bm;
    private void Awake()
    {
        if(GetComponentInParent<ButtonManager>() != null)
        {
            bm = GetComponentInParent<ButtonManager>();
        }
        if (GetComponent<ButtonManager>() != null)
        {
            bm = GetComponent<ButtonManager>();
        }
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
        //set english for custom buttons
        if (bm != null)
        {
            english = bm.buttonText;
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

            if (bm != null)
            {

                bm.enabled = false;
                bm.buttonText = english;
                bm.enabled = true;
            }
        }
        //FRENCH
        if (PlayerPrefs.GetInt("LocaleKey") == 1)
        {
            if (regTxt != null)
                regTxt.text = french;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = french;

            if (bm != null)
            {

                bm.enabled = false;
                bm.buttonText = french;
                bm.enabled = true;
            }
        }
        //SPANISH
        if (PlayerPrefs.GetInt("LocaleKey") == 2)
        {
            if (regTxt != null)
                regTxt.text = spanish;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = spanish;

            if (bm != null)
            {

                bm.enabled = false;
                bm.buttonText = spanish;
                bm.enabled = true;
            }
        }
        //ITALIAN
        if (PlayerPrefs.GetInt("LocaleKey") == 3)
        {
            if (regTxt != null)
                regTxt.text = italian;


            if (textMeshProUGUItxt != null)
                textMeshProUGUItxt.text = italian;

            if (bm != null)
            {

                bm.enabled = false;
                bm.buttonText = italian;
                bm.enabled = true;
            }
        }

    }
}
