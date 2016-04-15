using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Chapter1
{
    public class GrenadeExplosion : MonoBehaviour
    {
        // float destroyTime = 7;
        Collider[] hitColliders;
        public float blastRadius;
        public float explosionPower;
        public LayerMask explosionLayers;

        //public Text countText;
        //public Text winText;

        //int count;
        //Rigidbody rb;

        void Start()
        {
            // SetInitialReferences();
            // rb = GetComponent<Rigidbody>();
            //count = 0;
            //SetCountText();
            //winText.text = "";
        }


        void OnCollisionEnter(Collision col)
        {
            ExplosionWork(col.contacts[0].point);
            //Debug.Log(col.contacts[0].point.ToString());
        }

        void ExplosionWork(Vector3 explosionPoint)
        {
            hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);

            foreach (Collider hitCol in hitColliders)
            {

                if (hitCol.GetComponent<NavMeshAgent>() != null)
                {
                    hitCol.GetComponent<NavMeshAgent>().enabled = false;
                }

                // Debug.Log(hitCol.gameObject.name);

                if (hitCol.GetComponent<Rigidbody>() != null)
                {
                    hitCol.GetComponent<Rigidbody>().isKinematic = false;
                    hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionPower, explosionPoint, blastRadius, 1, ForceMode.Impulse);
                }

                else if (hitCol.CompareTag("Enemy"))
                {
                    hitCol.gameObject.SetActive(false);
                    //count = count + 1;
                    //SetCountText();
                }
            }
        }

        //void SetCountText()
        //{
        //    countText.text = "Count: " + count.ToString();
        //    if (count >= 35)
        //    {
        //        winText.text = "You Win!";
        //    }
        //}

    }
}