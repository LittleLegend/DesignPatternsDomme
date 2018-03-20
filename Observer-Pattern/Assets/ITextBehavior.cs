using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

interface ITextBehavior{
    
    void displayText(string text, TextMeshProUGUI textbox);

    void activeText(TextMeshProUGUI Text);

    void deactiveText(TextMeshProUGUI Text);
}
