using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Follower Tiger;
    public static List<Follower> TigerList { get; private set; }

    private void Start()
    {
        TigerList = new List<Follower>();
        SpawnTiger();
    }

    public void SpawnTiger()
    {
        var myTiger = Instantiate(Tiger, Vector3.zero, Quaternion.identity);
        TigerList.Add(myTiger);
    }
}
