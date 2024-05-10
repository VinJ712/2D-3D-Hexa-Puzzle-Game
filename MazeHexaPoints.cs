using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeHexaPoints : MonoBehaviour
{
    int point = 1;

    public AudioSource collect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MazeBall"))
        {
            collect.Play();
            GameManager.instance.pointManager.AddPointHexMaze(point);
            Destroy(this.gameObject);
        }
    }
}
