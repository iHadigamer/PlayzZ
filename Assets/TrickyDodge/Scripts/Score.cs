using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<Player>() != null)
        {
            Gamecontroler.Instance.Sc();
        }
    }
}
