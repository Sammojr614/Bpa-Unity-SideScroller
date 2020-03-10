using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPotin : MonoBehaviour
{
    public GameObject Active;
    public GameObject Unactive;
    public Transform SpawnPoint;
    public Transform CheckPoint;
    private void Start()
    {
        Active.SetActive(false);
        Unactive.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Active.SetActive(true);
            Unactive.SetActive(false);
            SpawnPoint.position = CheckPoint.position;
        }
    }
}
