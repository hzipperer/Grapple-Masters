using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject respawn;
    public GameObject goalMenuUI;
    public Vector3 respawnPosition;

    void Start()
    {
        respawnPosition = respawn.transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer == 7)
        {
            Rigidbody player = this.gameObject.GetComponent<Rigidbody>();
            player.velocity = Vector3.zero;
            player.angularVelocity = Vector3.zero;
            transform.position = respawnPosition;
            Destroy(GrapplingGun.joint);
        }
        else if (col.gameObject.name == "Goal")
        {
            goalMenuUI.SetActive(true);
            Time.timeScale = 0f;
            PauseMenu.GameIsPaused = true;
        }
    }
}
