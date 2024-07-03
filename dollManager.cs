using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class dollManager : MonoBehaviour
{
    [SerializeField] GameObject[] dollPrefabs;
    [SerializeField] GameObject[] dollPrefabsD;

    // Start is called before the first frame update

    public void spanDoll()
    {
        
        int r = Random.Range(0, dollPrefabs.Length);
        GameObject newObj = Instantiate(dollPrefabs[r],transform);
        newObj.transform.position = new Vector3(6f, 4.73f, 0);
        

    }
    public void spanDollD(int i,float dragX,float dragY)
    {
        GameObject downObj = Instantiate(dollPrefabsD[i]);
        downObj.transform.position = new Vector3(dragX, dragY, 0);
    }

}
