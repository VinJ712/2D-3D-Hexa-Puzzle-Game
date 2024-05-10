using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YellowPressurePlate : MonoBehaviour
{
    public int point = 1;
    public Animator animator;
    public AudioSource acquire;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowHex"))
        {
            acquire.Play();
            GameManager.instance.pointManager.AddPointHexPressurePlate(point);
            Debug.Log(GameManager.instance.pointManager.pressurePlatePoints);
            animator.SetBool("isCollided", true);
            Destroy(other.gameObject);
        }
    }
}
