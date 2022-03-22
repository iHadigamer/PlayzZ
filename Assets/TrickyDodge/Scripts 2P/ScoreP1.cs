using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreP1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<Player1>() != null)
        {
            GameControlerf2.Instance.ScP1();
        }
    }
}
