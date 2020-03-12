using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DeathPlain : MonoBehaviour
{
    public Transform Player;
    public Transform SpawnPoint;
    DataMgr data = DataMgr.Instance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string tojson = JsonUtility.ToJson(data);
            File.WriteAllText("PlayerSaveData.json", tojson);
            DataMgr fromjson = JsonUtility.FromJson<DataMgr>(tojson);
            Health.lives--;
            data.PlayerLives = Health.lives;
            Player.position = SpawnPoint.position;

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string tojson = JsonUtility.ToJson(data);
            File.WriteAllText("PlayerSaveData.json", tojson);
            DataMgr fromjson = JsonUtility.FromJson<DataMgr>(tojson);
            Health.lives--;
            data.PlayerLives = Health.lives;
            Player.position = SpawnPoint.position;
        }
    }

}
