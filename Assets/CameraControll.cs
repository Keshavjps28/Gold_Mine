using System.Collections;
using UnityEngine;

public class CameraControll : MonoBehaviour
{   public GameObject player;

	private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    //update is called once per frame
    void  LateUpdate ()
    {
       transform.position = player.transform.position + offset; 
    }
}
 