using UnityEngine;
using System.Collections;

namespace Chapter1
{
    public class WalkThroughWall : MonoBehaviour
    {

        Color myColor = new Color(0.5f, 1, 0.5f, 0.3f);
        GameManager_EventMaster eventMasterScript;

        void OnEnable()
        {
            SetInitialReferences();
            eventMasterScript.myGeneralEvent += SetLayerToNotSolid;
        }

        void OnDisable()
        {
            eventMasterScript.myGeneralEvent -= SetLayerToNotSolid;
        }

        void SetLayerToNotSolid()
        {
            gameObject.layer = LayerMask.NameToLayer("NotSolid");
            GetComponent<Renderer>().material.SetColor("_Color", myColor);
        }

        void SetInitialReferences()
        {
            eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManager_EventMaster>();
        }

    }
}
