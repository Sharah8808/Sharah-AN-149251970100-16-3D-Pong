using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinnerTransfer : MonoBehaviour
{
    public TextMeshProUGUI winText;

    private void Start() {
        winText.text = WinnerVar.Winner;
    }
}