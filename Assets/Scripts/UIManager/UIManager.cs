using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
   
    [SerializeField] TMP_Dropdown numberDropDown;
    public static UIManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    private void Start()
    {
        numberDropDown.ClearOptions();
        List<string> options = new List<string> { "Select Your Number" };
        for (int i=0;i<=Global.section;i++)
        {
            options.Add(i.ToString());
        }
        numberDropDown.AddOptions(options);
    }

    public void OnDropDownValueChanged()
    {
        Global.selectedNumber = numberDropDown.value-1;
    }
    public void OnClickReset()
    {
        GameManager.instance.onClickReset();
    }
    public void onClickSpinButton()
    {
        GameManager.instance.OnSpin();
    }
}
