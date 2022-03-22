using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    public bool isDead = false;

    void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<Player>() != null)
        {
            isDead = true;
            Gamecontroler.Instance.Die();
        }
    }
}
