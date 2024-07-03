using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class doll : MonoBehaviour
{
    [SerializeField] GameObject[] initDollPrehabs;
    bool downState;
    [SerializeField] public bool gameOver;
    [SerializeField] public GameObject gameoverObj;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        downState = false;
        gameOver = false;
    }

    public void Update()
    {
        detectGameover();

    }

    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        downState = true;
        if (tag == collision.gameObject.tag)
        {
            if (collision.gameObject.tag == "mumu")
            {
                float colX = collision.transform.position.x;
                float colY = collision.transform.position.y;
                float y = this.transform.position.y;
                Destroy(collision.gameObject);
                if (colY < y)
                {
                    GameObject doll = Instantiate(initDollPrehabs[1]);
                    doll.transform.position = new Vector3(colX, colY, 0);
                    Debug.Log("span gugu");
                }

            }
            else if (collision.gameObject.tag == "gugu")
            {
                float colX = collision.transform.position.x;
                float colY = collision.transform.position.y;
                float y = this.transform.position.y;
                Destroy(collision.gameObject);
                if (colY < y)
                {
                    GameObject doll = Instantiate(initDollPrehabs[2]);
                    doll.transform.position = new Vector3(colX, colY, 0);
                    Debug.Log("span popo");
                }
            }
            else if (collision.gameObject.tag == "popo")
            {
                float colX = collision.transform.position.x;
                float colY = collision.transform.position.y;
                float y = this.transform.position.y;
                Destroy(collision.gameObject);
                if (colY < y)
                {
                    GameObject doll = Instantiate(initDollPrehabs[3]);
                    doll.transform.position = new Vector3(colX, colY, 0);
                    Debug.Log("span piggy");
                }
            }
            else if (collision.gameObject.tag == "piggy")
            {
                float colX = collision.transform.position.x;
                float colY = collision.transform.position.y;
                float y = this.transform.position.y;
                Destroy(collision.gameObject);
                if (colY < y)
                {
                    GameObject doll = Instantiate(initDollPrehabs[4]);
                    doll.transform.position = new Vector3(colX, colY, 0);
                    Debug.Log("span turtle");
                }
            }
            else if (collision.gameObject.tag == "turtle")
            {
                float colX = collision.transform.position.x;
                float colY = collision.transform.position.y;
                float y = this.transform.position.y;
                Destroy(collision.gameObject);
                if (colY < y)
                {
                    GameObject doll = Instantiate(initDollPrehabs[5]);
                    doll.transform.position = new Vector3(colX, colY, 0);
                    Debug.Log("span cat");

                }
            }
            else if (collision.gameObject.tag == "cat")
            {
                float colX = collision.transform.position.x;
                float colY = collision.transform.position.y;
                float y = this.transform.position.y;
                Destroy(collision.gameObject);
                if (colY < y)
                {
                    GameObject doll = Instantiate(initDollPrehabs[6]);
                    doll.transform.position = new Vector3(colX, colY, 0);
                    Debug.Log("span fat");

                }

            }
        }

    }
    void detectGameover()
    {
        if (downState == true && transform.position.y > 2.2f)
        {
            Debug.Log("GameOver");
            gameOver = true;
            GameObject newObj = Instantiate(gameoverObj, transform);
            newObj.transform.position = new Vector3(0f, -6f, 0);


        }
    }
    
}
