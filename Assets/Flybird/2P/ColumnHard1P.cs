using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnHard1P : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.GetComponent<BirdHardP1>() != null)
        {
            GameControllerHard.Instance.Score();
        }
    }
}
