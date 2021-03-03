using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject respawn;
    public Vector3 respawnPosition;

    void Start()
    {
        respawn = GameObject.Find("Respawn");
        respawnPosition = respawn.transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Lava")
        {
            Rigidbody player = this.gameObject.GetComponent<Rigidbody>();
            player.velocity = Vector3.zero;
            player.angularVelocity = Vector3.zero;
            transform.position = respawnPosition;
        }
    }
}
