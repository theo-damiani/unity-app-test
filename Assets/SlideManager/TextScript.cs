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
/*
    LanguageToggle languageToggle;

    private enum Language {
        EN,
        FR,
        SIZE
    }

    private Language currentLanguage = Language.EN;

    // Start is called before the first frame update
    void Start()
    {
        languageToggle = FindObjectOfType<LanguageToggle>();
        languageToggle.OnLanguageToggle += SwitchLanguage;

        SetLanguage(currentLanguage);
    }

    private void SetLanguage(ActiveLanguage language){
        switch (language) {
            case Language.EN: {
                tmpUI.text = EN;
                break;
            }
            case Language.FR: {
                tmpUI.text = FR;
                break;
            }
        }
    }

    void SwitchLanguage() {
        Language nextLanguage = (Language)(((int)currentLanguage+1) % (int)Language.SIZE);
        SetLanguage(nextLanguage);
        currentLanguage = nextLanguage;
    }
    */
}
