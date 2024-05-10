using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageDeactivator : MonoBehaviour
{
    [Header("Level One")]
    public GameObject cageDoor;
    public GameObject cageDoorTwo;
    public Animator portalLvlOne;
    public GameObject portalFX;

    [Header("Level Four")]
    public Animator cage;
    public Animator portal;

    [Header("Level Four Sana huhu ang gulo na")]
    public GameObject portalTut;
    public AudioSource portalSound;
    public AudioSource switchSfx;
    public AudioSource acquire;
    public AudioSource release;

    private void OnTriggerEnter(Collider other)
    {
        //LevelFive3D
        if (other.gameObject.CompareTag("MazeBall"))
        {
            release.Play();
            cage.SetBool("isMazeComplete", true);
            portal.SetBool("isMazeComplete", true);
        } 

        //LevelOne3D
        if (other.gameObject.CompareTag("Player3"))
        {
            switchSfx.Play();
            cageDoor.SetActive(false);
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("MazeBall2"))
        {
            acquire.Play();
            portalSound.Play();
            cageDoorTwo.SetActive(true);
            portalFX.SetActive(true);
            portalLvlOne.SetBool("isMazeComplete", true);
        }

        if (other.gameObject.CompareTag("MazeBall3"))
        {
            Destroy(other.gameObject);
            portalSound.Play();
            portalTut.SetActive(true);
        }
    }
}
