using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerManager : MonoBehaviour
{
    public int maxBall = 3;
    public int spamInterval;
    private List<GameObject> ballList;
    public GameObject ball;

    public Transform spawnArea;
    private float timer;

    void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
        GenearateBall();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spamInterval)
        {
            GenearateBall();
            timer -= spamInterval;
        }
    }

    public void GenearateBall(){
        int spawnPos = Random.Range(1,5);
        if (spawnPos == 1){
            GenearateBallPost(1);
        } else if (spawnPos == 2){
            GenearateBallPost(2);
        } else if (spawnPos == 3){
            GenearateBallPost(3);
        } else if (spawnPos == 4){
            GenearateBallPost(4);
        }
    }

    public void GenearateBallPost(int spawnPoints){
        Vector3 speedSpawned;
        Vector3 spawnPos;
        if (ballList.Count >= maxBall){
            return;
        }
        if (spawnPoints == 1)
        {
            speedSpawned = new Vector3(-12,0,10);
            spawnPos = new Vector3(12, 2, -12);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 2)
        {
            speedSpawned = new Vector3(12,0, 9);
            spawnPos = new Vector3(-12, 2, -12);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 3)
        {
            speedSpawned = new Vector3(9,0,-9);
            spawnPos = new Vector3(-12, 2, 12);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 4)
        {
            speedSpawned = new Vector3(-14,0,-8);
            spawnPos = new Vector3(12, 2, 12);
            SpawnBall(speedSpawned, spawnPos);
        }
        Debug.Log(ballList.Count);
    }

    private void SpawnBall(Vector3 speedSpawned, Vector3 spawnPos){
        GameObject ballSpawned = Instantiate(ball, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity, spawnArea);
        ballSpawned.GetComponent<BallController>().speed = speedSpawned;
        ballSpawned.SetActive(true);
        ballList.Add(ballSpawned);
    }

    public void RemoveBall(GameObject ballObject){
        ballList.Remove(ballObject);
        Destroy(ballObject);
    }
}
