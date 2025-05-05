using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Spawns a random animal
    void SpawnRandomAnimal()
    {
        Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-15, 15), Random.Range(0, 1), Random.Range(30, 40)), animalPrefabs[animalIndex].transform.rotation);
        animalIndex = Random.Range(0, animalPrefabs.Length);
    }
}
