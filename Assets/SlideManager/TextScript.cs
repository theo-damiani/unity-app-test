using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI tmpUI;

    [SerializeField] 
    private string EN;

    [SerializeField] 
    private string FR;

    LanguageToggle languageToggle;

    void Start()
    {
        languageToggle = FindObjectOfType<LanguageToggle>();
        languageToggle.OnLanguageToggle += SetLanguage;

        // Set English as the default language.
        SetLanguage(LanguageToggle.ActiveLanguage.EN);
    }

    private void SetLanguage(LanguageToggle.ActiveLanguage language){
        switch (language) {
            case LanguageToggle.ActiveLanguage.EN: {
                tmpUI.text = EN;
                break;
            }
            case LanguageToggle.ActiveLanguage.FR: {
                tmpUI.text = FR;
                break;
            }
        }
    }
}
