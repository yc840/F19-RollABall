using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject PLAYER;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - PLAYER.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PLAYER.transform.position + offset;
    }
}
