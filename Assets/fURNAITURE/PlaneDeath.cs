using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDeath : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider col)
    {
        CharacterController playerController = col.GetComponent<CharacterController>();
        if (respawnPoint != null)
        {
            col.transform.position = respawnPoint.position;
            col.attachedRigidbody.velocity = Vector3.zero;
        }
    }
}
