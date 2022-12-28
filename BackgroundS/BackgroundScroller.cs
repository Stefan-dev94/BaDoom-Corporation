using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
   [SerializeField] public float scrollSpeed = -6;
   [SerializeField] public BoxCollider2D colLider;
   [SerializeField] public Rigidbody2D rb;

    public bool _backGroundScrollTrue = true;
    private float width;

    private void Start()
    {
        colLider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(scrollSpeed, 0);

        width = colLider.size.x;
        colLider.enabled = false;
    }

    private void FixedUpdate()
    {
        StartScroll();
    }

    public void StartScroll()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }

    public void Stop()
    {
        rb.velocity = new Vector2(0, 0);
    }
}

