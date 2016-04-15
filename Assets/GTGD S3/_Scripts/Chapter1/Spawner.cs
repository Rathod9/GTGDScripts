using UnityEngine;
using System.Collections;

namespace Chapter1
{
    public class Spawner : MonoBehaviour
    {
        public GameObject objectToSpawn;
        public int numberOfEnemies;
        float spawnRadius = 10;
        Vector3 spawnPos;
        private GameManager_EventMaster eventMasterScript;

        void OnEnable()
        {
            SetInitialReferences();
            eventMasterScript.myGeneralEvent += SpawnObject;
        }

        void OnDisable()
        {
            eventMasterScript.myGeneralEvent -= SpawnObject;
        }

        void SpawnObject()
        {
            for (int i = 0; i < numberOfEnemies; i++)
            {
                if (objectToSpawn)
                {
                    spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
                    Instantiate(objectToSpawn, spawnPos, Quaternion.identity);

                }
            }
        }

        void SetInitialReferences()
        {
            eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManager_EventMaster>();
        }

    }
}