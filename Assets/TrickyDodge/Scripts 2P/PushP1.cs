using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushP1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<Player1>() != null)
        {
            obj.transform.position += new Vector3(-2f, 0f, 0f);
            gameObject.SetActive(false);
            transform.parent.GetChild(0).gameObject.SetActive(false);
        }
    }
}
