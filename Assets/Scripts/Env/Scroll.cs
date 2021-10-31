using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private MeshRenderer meshRenderer;
    private float xScroll;

    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        Time.timeScale = 1F;
    }

    // Update is called once per frame
    void Update()
    {
        xScroll = Time.time * scrollSpeed;
        Vector2 offset = new Vector2(0f, xScroll);
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
