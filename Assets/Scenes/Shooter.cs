using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    KeyCode fireButton;

    [SerializeField]
    Vector2 fireDirection = Vector2.up;

    [SerializeField]
    float coolDown;

    [SerializeField]
    Projectile projectilePrefab;
    [SerializeField]
    Transform spawnLocation;

    public AudioClip mySound;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if ((fireButton == KeyCode.None || Input.GetKey(fireButton)) && timer <= 0)
        {
            AudioSource.PlayClipAtPoint(mySound, transform.position);
            Vector2 pos = transform.position;
            if(spawnLocation != null)
            {
                pos = spawnLocation.position;
            }

            Projectile p = Instantiate(projectilePrefab, pos, Quaternion.identity);
            p.Init(fireDirection);

            timer = coolDown;
        }
    }
}
