using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TvTextChange : MonoBehaviour
{
    public TMPro.TMP_Text tmpText;

    public List<string> screenText = new List<string>();

    private int index;
    private void Awake()
    {
        index = -1;
        if (tmpText != null) tmpText.text = "";
    }

    public void ShowNextText()
    {
        index += 1;
        if(index < screenText.Count)
        {
            if(tmpText != null)
            {
                tmpText.text = screenText[index];
            }
        }
    }
}
