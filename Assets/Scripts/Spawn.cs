using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPoints;

    [SerializeField] GameObject Antidote;
    [SerializeField] GameObject RedVirus;
    public GameObject Player;
    public GameObject[] GoodOnes;

    public int Target;

    void Start()
    {
        InvokeRepeating("StartCoroutines", 10f, 2f);
    }

    private void Awake()
    {
        System.Random randomGen = new System.Random();

        Target = randomGen.Next(0, 3);

        if (GoodOnes.Length < 1)
        {
            GoodOnes = GameObject.FindGameObjectsWithTag("GoodOnes");
        }
    }
    void StartCoroutines()
    {
        StartCoroutine(SpawnAntidoteRepeatedly());
        StartCoroutine(SpawnRedVirusRepeatedly());
    }
    private IEnumerator SpawnAntidoteRepeatedly()
    {
        Instantiate(Antidote, transform.position, Quaternion.identity);
        Destroy(this);

        yield return new WaitForSeconds(1);
    }
    private IEnumerator SpawnRedVirusRepeatedly()
    {
        Instantiate(RedVirus, transform.position, Quaternion.identity);
        Destroy(this);

        yield return new WaitForSeconds(1);
    }
}
