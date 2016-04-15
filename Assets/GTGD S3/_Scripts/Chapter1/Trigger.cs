using UnityEngine;
using System.Collections;

namespace Chapter1
{
    public class Trigger : MonoBehaviour
    {
        GameManager_EventMaster eventMasterScript;

        void Start()
        {
            SetInitialRefereces();
        }

        void OnTriggerEnter(Collider other)
        {
            eventMasterScript.CallMyGeneralEvent();
            Destroy(gameObject);
        }

        void SetInitialRefereces()
        {
            eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManager_EventMaster>();
        }
    }
}
