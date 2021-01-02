using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpriteChanger : MonoBehaviour
{
    [SerializeField] private Sprite _openDoor;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Thief>(out Thief thief))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = _openDoor;
            transform.position = new Vector3(-1.76f, -3.21f, 0);
        }
    }
}
