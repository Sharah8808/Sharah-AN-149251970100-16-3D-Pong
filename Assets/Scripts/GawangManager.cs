using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GawangManager : MonoBehaviour
{
    public GameObject gawangAts, gawangBwh, gawangKiri, gawangKnn;
    bool P1 = true, P2 = true, P3 = true, P4 = true;
    public int playerCounter;

    private void Update() {
        if (playerCounter == 3){
            if (P1){
                WinnerVar.Winner = "Player 1 is the Winner!";
                SceneManager.LoadScene("GameOver");
            }
            if (P2){
                WinnerVar.Winner = "Player 2 is the Winner!";
                SceneManager.LoadScene("GameOver");
            }
            if (P3){
                WinnerVar.Winner = "Player 3 is the Winner!";
                SceneManager.LoadScene("GameOver");
            }
            if (P4){
                WinnerVar.Winner = "Player 4 is the Winner!";
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void ActivateGawangAtas(){
        playerCounter += 1;
        P1 = false;
        gawangAts.GetComponent<MeshRenderer>().enabled = true;
        gawangAts.GetComponent<Collider>().isTrigger = false;
    }

    public void ActivateGawangBawah(){
        playerCounter += 1;
        P2 = false;
        gawangBwh.GetComponent<MeshRenderer>().enabled = true;
        gawangBwh.GetComponent<Collider>().isTrigger = false;    
    }

    public void ActivateGawangKiri(){
        playerCounter += 1;
        P3 = false;
        gawangKiri.GetComponent<MeshRenderer>().enabled = true;
        gawangKiri.GetComponent<Collider>().isTrigger = false;    
    }

    public void ActivateGawangKanan(){
        playerCounter += 1;
        P4 = false;
        gawangKnn.GetComponent<MeshRenderer>().enabled = true;
        gawangKnn.GetComponent<Collider>().isTrigger = false;    
    }
}
