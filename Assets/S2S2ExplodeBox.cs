using UnityEngine;
using System.Collections;
using System;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S2S2ExplodeBox : MonoBehaviour
    {
        public float forceRadius = 5f; // Radius of the sphere of influence
        public float forceStrength = 10f; // Strength of the force
      //  public GameObject sphere1;
        public GameObject crate;

        public AudioSource audioSource;

        // Set pitch variation range
        [SerializeField] private float minPitch = 0.9f;
        [SerializeField] private float maxPitch = 1.1f;

      

        void ApplySphericalForce()
        {
            // Find all colliders within the sphere of influence
            Collider[] colliders = Physics.OverlapSphere(transform.position, forceRadius);
            
            audioSource.Play(); // Play the sound
            foreach (Collider nearbyObject in colliders)
            {
                Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
              //  sphere1.gameObject.SetActive(true);
               // textMan.positionChanged = true;
            //    textMan.arrayPos = 5;
                StartCoroutine(RemoveCrate());
                // Apply force only if the object has a Rigidbody
                if (rb != null)
                {
                    // Calculate direction from the center to the object
                    Vector3 direction = (nearbyObject.transform.position - transform.position).normalized;

                    // Apply force in the calculated direction
                    rb.AddForce(direction * forceStrength, ForceMode.Impulse);
                }
            }
        }

        // Call the force function when needed, for example when pressing a key
      

        // Optional: visualize the force radius in the editor
        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, forceRadius);
        }

        public IEnumerator RemoveCrate()
        {
            yield return new WaitForSeconds(2);
            Destroy(crate);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Club"))
            {
                audioSource.pitch = UnityEngine.Random.Range(minPitch, maxPitch); // Set random pitch
                ApplySphericalForce();
                Debug.Log("This explosion triggered");
            }
        }
    }
}