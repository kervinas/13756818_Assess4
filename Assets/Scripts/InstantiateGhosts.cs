using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class InstantiateGhosts : MonoBehaviour
{
    [SerializeField]
    private GameObject redGhost;
    [SerializeField]
    private GameObject blueGhost;
    [SerializeField]
    private GameObject greenGhost;
    [SerializeField]
    private GameObject yellowGhost;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;

    void Start()
    {
        InstantiateGhost();
    }

    private void InstantiateGhost()
    {
        Instantiate(redGhost, spawnPoint1.position, Quaternion.identity);
        Instantiate(blueGhost, spawnPoint2.position, Quaternion.identity);
        Instantiate(greenGhost, spawnPoint3.position, Quaternion.identity);
        Instantiate(yellowGhost, spawnPoint4.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
