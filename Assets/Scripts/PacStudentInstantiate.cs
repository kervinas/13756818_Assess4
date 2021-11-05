using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class PacStudentInstantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject pacStudent;

    public Transform spawnPoint;

    void Start()
    {
        InstantiatePacman();
    }

    public void InstantiatePacman()
    {
        Instantiate(pacStudent, spawnPoint.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
