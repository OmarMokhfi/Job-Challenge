using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMouvement : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float enemySpeed;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemySpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPosition = new Vector2(player.transform.position.x, player.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, enemySpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            GameObject.FindGameObjectWithTag("scoreHandler").GetComponent<scoreHandler>().substractScore();
        }
    }
 
}
