using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Localization.Settings;

public class LocaleSelector : MonoBehaviour
{
    private bool active = false;
    public void ChangeLocale(int localeID)
    {
        if (active == true)
            return;
        StartCoroutine(SetLocale(localeID));
    }

    IEnumerator SetLocale(int _locaeID)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_locaeID];
        active = false;
    }
}
