using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;

    private Rigidbody rig;
    public float maxSpeed = 20.0f;

    public Collider gawangAts, gawangBwh, gawangKir, gawangKnn;
    public BallSpawnerManager manager;
    public ScoreManager managerScore;
    
    void Start(){
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    void Update(){    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Paddle" || 
        other.gameObject.tag == "Ball" || 
        other.gameObject.tag == "Pillar" || 
        other.gameObject.tag == "GawangAtas" ||
        other.gameObject.tag == "GawangBawah" ||
        other.gameObject.tag == "GawangKiri" ||
        other.gameObject.tag == "GawangKanan")
        {
            if (rig.velocity.magnitude < maxSpeed){
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other == gawangAts)
        {
            Debug.Log("gawaaangg atsasas");
            managerScore.AddPlayer1Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawangBwh)
        {
            managerScore.AddPlayer2Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawangKir)
        {
            managerScore.AddPlayer3Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawangKnn)
        {
            managerScore.AddPlayer4Score(1);
            manager.RemoveBall(gameObject);
        }
    }
}
