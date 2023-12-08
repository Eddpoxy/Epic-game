using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    [SerializeField]
    int hurtAmount = 1;

    [SerializeField]
    public GameObject obj;

   
    public AudioClip mySound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth phealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (phealth == null)
        {
            return;
        }

        phealth.Hurt(hurtAmount);
        Destroy(obj);
        AudioSource.PlayClipAtPoint(mySound, transform.position);
    }
}
