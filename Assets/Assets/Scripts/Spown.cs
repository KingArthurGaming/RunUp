using System.Collections;
using UnityEngine;

public class Spown : MonoBehaviour
{

    public GameObject enemies;

    public Vector3 spownValues;
    public float spownwait;
    //public float spownMustwait;
    //public float spownleastwait;
    public int startwait;
    //public bool stop;
    public Transform spown;
    public Vector3 Setting;
    //float XY = 0f;
    //public int randenemy;
    //int Gems;
    void Start()
    {
        StartCoroutine(waitspowner());
    }

    //void FixedUpdate()
    //{
    //    spownwait = Random.Range(spownleastwait, spownMustwait);
    //}
    IEnumerator waitspowner()
    {
        yield return new WaitForSeconds(startwait);
        while (true)
        {
            //randenemy = Random.Range(0, 14);

            transform.position = spown.position + Setting;

            Vector3 spownPosition = new Vector3(Random.Range(-spownValues.x, spownValues.x), 1.5f, 0);
            Vector3 Position = transform.position + spownPosition;
            Instantiate(enemies, Position, Quaternion.identity);
            yield return new WaitForSeconds(spownwait);

        }

    }

}
