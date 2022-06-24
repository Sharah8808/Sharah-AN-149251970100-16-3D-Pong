using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode leftKey, rightKey, upKey, downKey;
    public bool isP1,isP2,isP3,isP4;
    private Rigidbody rig;

    private void Start(){
        rig = GetComponent<Rigidbody>();
    }

    private void Update(){
        MoveObject(GetInput());
        // Debug.Log("Paddle speed : " + speed);
    }
    
    private Vector3 GetInput(){
        if (Input.GetKey(leftKey)){
            return Vector3.left * speed;
        }
        else if (Input.GetKey(downKey)){
            return Vector3.back * speed;
        }
        else if (Input.GetKey(rightKey)){
            return Vector3.right * speed;
        }
        else if (Input.GetKey(upKey)){
            return Vector3.forward * speed;
        }
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement){
        rig.velocity = movement;
    }

    public void destroyPlayer(){
        if (isP1)
        {
            gameObject.SetActive(false);

        }
        if (isP2)
        {
            gameObject.SetActive(false);
        }
        if (isP3)
        {
            gameObject.SetActive(false);
        }
        if (isP4)
        {
            gameObject.SetActive(false);
        }
    }
}
