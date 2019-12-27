using UnityEngine;

public class Spowner : MonoBehaviour {


    [SerializeField] GameObject[] brefabs;
    float waiteTimer = 3f;


    private void Start()
    {
        InvokeRepeating("Spowne", 1, waiteTimer)
    }

    void Spowne()
    {
        int index = Random.Range(0, brefabs.Length);
        Instantiate(brefabs[index], transform.position, Quaternion.identity);
    }

 
} // end class
