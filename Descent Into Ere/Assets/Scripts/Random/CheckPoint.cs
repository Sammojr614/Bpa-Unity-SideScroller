using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform SpawnPointPos;
    public Transform CheckPointPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnPointPos.position = CheckPointPos.position;
    }

}
