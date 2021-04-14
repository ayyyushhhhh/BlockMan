using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class PrefabsSpawnner : MonoBehaviour
{

  [SerializeField] private GameObject[] Platform;
  private float zSpawn = 40f;
 // private float[] xSpawn = new float[3] {2.5f,-2.5f,0};
  private Transform playerTransform;
  [SerializeField] private float TileLength = 60f;
  [SerializeField] private int NumberofTiles = 10;

  private float safeZone = 25f;

  private void Awake()
  {
    Time.timeScale = 1;
  }

  private void Start()
  {
    playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
  
  }

  private void Update()
  {
    if (playerTransform.position.z > (zSpawn - NumberofTiles * TileLength))
    {
      SpawnPlatfroms();
     
    }
  }



  private void SpawnPlatfroms()
  {
    GameObject go;
    go = Instantiate(Platform[Random.Range(0,Platform.Length)])as GameObject;
   // int position = Random.Range(0, 3);
    go.transform.position = new Vector3(0f, 0f, zSpawn);
    zSpawn += TileLength;
  }
}
