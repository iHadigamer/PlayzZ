using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKillerP2 : MonoBehaviour
{
    public bool isDead = false;

    void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<Player1>() != null || obj.GetComponent<Player2>() != null)
        {
            isDead = true;
            GameControlerf2.Instance.PDie();
            obj.gameObject.SetActive(false);
        }
    }
}
