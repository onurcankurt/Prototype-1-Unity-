using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private static Vector3 thirdViewOffset = new Vector3(0, 5, -7);
    private static Vector3 firstViewOffset = new Vector3(0, 2, 1);
    private Vector3 offset = thirdViewOffset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(offset == thirdViewOffset && Input.GetKeyDown(KeyCode.V))
        {
            offset = firstViewOffset;
            
        } else if(offset == firstViewOffset && Input.GetKeyDown(KeyCode.V))
        {
            offset = thirdViewOffset;
        }
        transform.position = player.transform.position + offset;
    }
}
