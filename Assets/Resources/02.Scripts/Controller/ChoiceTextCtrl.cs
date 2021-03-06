using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceTextCtrl : MonoBehaviour
{
    [SerializeField]
    private Text DaysText = null;

    void UpdateDayText()
    {
        DaysText.text = "Day " + GlobalGameObjectMgr.Inst.CurDay.ToString() + "/" + GlobalGameObjectMgr.Inst.MaxDay.ToString();
    }

    void OnEnable()
    {
        UpdateDayText();
    }
}
