using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ply1Score;
    public Text ply2Score;
    public Text ply3Score;
    public Text ply4Score;

    public ScoreManager manager;

    private void Update(){
        ply1Score.text = manager.player1Score.ToString();
        ply2Score.text = manager.player2Score.ToString();
        ply3Score.text = manager.player3Score.ToString();
        ply4Score.text = manager.player4Score.ToString();
    }
}
