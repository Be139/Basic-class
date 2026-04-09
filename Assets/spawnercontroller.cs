using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class spawnercontroller : MonoBehaviour
{
    public GameObject cube;
    public Transform cubeParent;
    int currentCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCount < 2000)
        { 
         GameObject tempObj = Instantiate(cube);
         tempObj.AddComponent<Rigidbody>();
         tempObj.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);

         float randomScale = Random.Range(0.7f, 2.5f);
         tempObj.transform.localScale = new Vector3(randomScale, randomScale, randomScale);

         float randomX = Random.Range(-5f, 5f);
         float randomY = Random.Range(15f, 30f);
         float randomZ = Random.Range(-5f, 5f);
         tempObj.transform.position = new Vector3(randomX, randomY, randomZ);

            tempObj.transform.SetParent(cubeParent);

            currentCount++;

        }
    }
}
