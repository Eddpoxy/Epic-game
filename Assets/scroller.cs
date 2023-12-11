using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class scroller : MonoBehaviour
{
    // Start is called before the first frame update  
    public float speed;
    [SerializeField]
    private Renderer BgRender;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BgRender.material.mainTextureOffset += new Vector2(speed * Time.deltaTime,0);
    }
}
