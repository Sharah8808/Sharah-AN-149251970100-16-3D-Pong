using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool isPly1, isPly2, isPly3, isPly4;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider other){
        Debug.Log("logggg");
        if(other == ball){
            if(isPly1){
                manager.AddPlayer1Score(1);
            } else if(isPly2){
                manager.AddPlayer2Score(1);
                Debug.Log("bawaah");
            } else if(isPly3){
                manager.AddPlayer3Score(1);
            } else if(isPly4){
                manager.AddPlayer4Score(1);
            }
        }
    }
}
