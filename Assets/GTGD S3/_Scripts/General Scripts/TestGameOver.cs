using UnityEngine;
using System.Collections;

namespace S3
{
    public class TestGameOver : MonoBehaviour
    {

        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.O))
            {
                GetComponent<GameManager_Master>().CallEventGameOver();
            }
        }
    }
}