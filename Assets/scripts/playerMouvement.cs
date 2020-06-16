using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMouvement : MonoBehaviour
{
    [SerializeField] private float speed;

    void Start()
    {
        speed = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float y = Input.GetAxis("Vertical") * speed;
        transform.position += new Vector3(x, y, 0f);

        followMouse();
    }

    void followMouse(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);
        transform.up = direction;
    }

}
