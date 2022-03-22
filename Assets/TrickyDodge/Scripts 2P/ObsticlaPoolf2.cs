using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticlaPoolf2 : MonoBehaviour
{
    public float spawnRate = 3f;
    public int columnPoolSize = 10;

    private float timeSinceLastSpawn;
    private float spawnXPosition = 98f;
    private int currentColumn = 0;

    public GameObject ob;

    private GameObject[] obs;
    private Vector3 objectPoolPosition = new Vector3(15, -25f);
    System.Random random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        obs = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            obs[i] = (GameObject)Instantiate(ob, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

        int a = random.Next(1, 3);
        timeSinceLastSpawn += Time.deltaTime;
        if (a == 1)
        {
            if (!GameControlerf2.Instance.isGameOver && timeSinceLastSpawn >= spawnRate)
            {
                timeSinceLastSpawn = 0;
                float spawnYPosition = 7f;
                obs[currentColumn].transform.position = new Vector3(spawnXPosition, spawnYPosition, -1f);
                obs[currentColumn].transform.rotation = Quaternion.Euler(88f, 0, 0);
                obs[currentColumn].transform.GetChild(0).GetComponent<BoxCollider>().center = new Vector3(0.5f, 0, 0.25f);
                if (!obs[currentColumn].transform.GetChild(0).gameObject.active){
                    obs[currentColumn].transform.GetChild(0).gameObject.SetActive(true);
                    obs[currentColumn].transform.GetChild(2).gameObject.SetActive(true);
                }
                if (!obs[currentColumn].transform.GetChild(1).gameObject.active){
                    obs[currentColumn].transform.GetChild(1).gameObject.SetActive(true);
                    obs[currentColumn].transform.GetChild(3).gameObject.SetActive(true);
                }
                currentColumn++;

                if (currentColumn >= columnPoolSize) { currentColumn = 0; }
            }
        }
        else if (a == 2)
        {
            if (!GameControlerf2.Instance.isGameOver && timeSinceLastSpawn >= spawnRate)
            {
                timeSinceLastSpawn = 0;
                float spawnYPosition = 0f;
                obs[currentColumn].transform.position = new Vector3(spawnXPosition, spawnYPosition, -1f);
                obs[currentColumn].transform.rotation = Quaternion.Euler(88f, 0, 0);
                obs[currentColumn].transform.GetChild(0).GetComponent<BoxCollider>().center = new Vector3(0.5f, 0, -0.25f);
                if (!obs[currentColumn].transform.GetChild(0).gameObject.active)
                {
                    obs[currentColumn].transform.GetChild(0).gameObject.SetActive(true);
                    obs[currentColumn].transform.GetChild(2).gameObject.SetActive(true);
                }
                if (!obs[currentColumn].transform.GetChild(1).gameObject.active)
                {
                    obs[currentColumn].transform.GetChild(1).gameObject.SetActive(true);
                    obs[currentColumn].transform.GetChild(3).gameObject.SetActive(true);
                }
                currentColumn++;

                if (currentColumn >= columnPoolSize) { currentColumn = 0; }
            }
        }

    }
}
