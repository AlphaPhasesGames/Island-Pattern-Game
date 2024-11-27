using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Scene2CollapeColumn : MonoBehaviour
{
    public Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.isKinematic = false;
            StartCoroutine(DeleteColumn());
        }
    }

    public IEnumerator DeleteColumn()
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
}
