using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public void Init(Vector2 velocity)
    {
        Rigidbody2D rb2 = GetComponent<Rigidbody2D>();
        if(rb2 == null)
        {
            Debug.LogError("Rigidbody missing");
            return;
        }

        rb2.velocity = velocity;
        StartCoroutine(DelayedAction());
     
    }
    IEnumerator DelayedAction()
    {
        Debug.Log("Start of Coroutine");
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        Debug.Log("After 2 seconds");
        Destroy(gameObject);
    }
}
