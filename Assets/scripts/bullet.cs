using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField] private float bulletPower;
    [SerializeField] private float bulletLife;
    // Start is called before the first frame update
    void Start()
    {
        bulletPower = 1.7f;
        bulletLife = 1f;
        Vector2 bulletPosition = new Vector2(transform.position.x, transform.position.y);
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        //transform.position = Vector2.MoveTowards(bulletPosition, mousePosition, bulletSpeed * Time.deltaTime);
        GetComponent<Rigidbody2D>().velocity = (mousePosition - bulletPosition) * bulletPower;
        StartCoroutine(WaitAndDestroy());
        Debug.Log(PlayerPrefs.GetInt("HighScore"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitAndDestroy(){
      yield return new WaitForSeconds(bulletLife);
      Destroy (gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("enemy")){
            GameObject.FindGameObjectWithTag("scoreHandler").GetComponent<scoreHandler>().addScore();
            Destroy(this.gameObject);
        }
    }
}
