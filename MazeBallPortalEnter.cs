using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class MazeBallPortalEnter : MonoBehaviour
{
    public Animator portalAnim;
    public GameObject door;
    public AudioSource acquire;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MazeBall"))
        {
            acquire.Play();
            portalAnim.SetBool("isBallEntered", true);
            door.SetActive(true);
        }
    }
}
