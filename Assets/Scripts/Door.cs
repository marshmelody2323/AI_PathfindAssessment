using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;
    [SerializeField] private float speed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, Mathf.PingPong(Time.time * speed, 1));
    }

    void OnTriggerEnter(Collider _end)
    {
        if (_end.gameObject.tag == "DoorSpeedChanger")
        {
            speed = Random.Range(0.1f, 1f);
        }
    }
}
