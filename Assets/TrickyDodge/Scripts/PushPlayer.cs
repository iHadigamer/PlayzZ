using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushPlayer : MonoBehaviour
{

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<Player>() != null)
        {
            obj.transform.position += new Vector3(-1f, 0f, 0f);
            transform.parent.gameObject.SetActive(false);
            Gamecontroler.Instance.mis();
        }
    }

}
