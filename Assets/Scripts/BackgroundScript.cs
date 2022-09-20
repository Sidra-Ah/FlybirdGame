using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // [Range(-1f, 1f)]
    public float ScrollSpeed;
    public Renderer BackgroundRenderer;
    // private float offset;
    // private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        // mat = GetComponent<Renderer>().material;
             BackgroundRenderer.material.mainTextureOffset += new Vector2(ScrollSpeed * Time.deltaTime, 0f);
    }

    // Update is called once per frame
    void Update()
    {
    //   offset += (Time.deltaTime * ScrollSpeed) / 10f;
    //   mat.SetTextureOffset("_MainTex", new Vector2(offset,0));  
        BackgroundRenderer.material.mainTextureOffset += new Vector2(ScrollSpeed * Time.deltaTime, 0f);
    }
}
