using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreP2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<Player2>() != null)
        {
            GameControlerf2.Instance.ScP2();
        }
    }
}
