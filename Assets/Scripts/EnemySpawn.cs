
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public int enemyPoolSize = 1;  //enemyPoolSize

    public GameObject enemyPrefab; //Enemy prefab

    public float spawnRate = 2f; //Rate at which enemy spawns



    private GameObject[] enemy; //collection of enemies

    private Vector3 enemyPoolPosition = new Vector2(1, 6); //holding position

    private float timeSinceLastSpawned; //time count

    private int currentSpawn;

    private float time = 0;
    PlayerController player;



    // Start is called before the first frame update
    void Start()
    {
        //initialize pool collection
        enemy = new GameObject[enemyPoolSize];

        for (int i = 0; i < enemyPoolSize; i++) //loop through collection
        {

            enemy[i] = Instantiate(enemyPrefab, enemyPoolPosition, Quaternion.identity);
            //create individual pool
        }

        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time>2.0f && player!=null)
        {
            timeSinceLastSpawned += Time.deltaTime;

            if (timeSinceLastSpawned > spawnRate)//checking if enemy was spawned earlier
            {

                timeSinceLastSpawned = 0;

                float spawnXPosition = Random.Range(-2.5f, 2.5f); //random x position

                enemy[currentSpawn].transform.position = new Vector2(spawnXPosition, 5.5f);

                currentSpawn++; //increase collection

                if (currentSpawn >= enemyPoolSize)
                {
                    currentSpawn = 0;
                }

            }

        }

    }

}



/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float xPosition;
    // Start is called before the first frame update
    void Start()
    {
        startSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float randomX = Random.Range(-xPosition, xPosition);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);
        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
    void startSpawn()
    {
        InvokeRepeating("SpawnEnemy",1f,2f);
    }

}
*/