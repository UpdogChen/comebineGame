using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObj : MonoBehaviour
{
    [SerializeField] GameObject[] dragDollPrefabs;
    private Vector3 screenPoint;
    private Vector3 offset;

    
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4f, 6.5f), Mathf.Clamp(transform.position.y, 3.6f, 6f), 0);
    }

    public void OnMouseDown()
    {
        Debug.Log("click");
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    public void OnMouseDrag()
    {
        
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y,screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
        
    }

    public void OnMouseUp()
    {
        
        string dragTag = transform.tag;
        Debug.Log(dragTag);
        float dragX = transform.position.x;
        float dragY = transform.position.y;
        Destroy(gameObject);
        if (dragTag == "mumuD")
        {
            transform.parent.GetComponent<dollManager>().spanDollD(0,dragX,dragY);
            
        }else if(dragTag == "guguD")
        {
            transform.parent.GetComponent<dollManager>().spanDollD(1, dragX, dragY);
        }
        else if(dragTag == "popoD")
        {
            transform.parent.GetComponent<dollManager>().spanDollD(2, dragX, dragY);
        }

        transform.parent.GetComponent<dollManager>().spanDoll();
    }

}
