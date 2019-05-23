using UnityEngine;

public class FallowMe : MonoBehaviour {
    public Transform player;
    public Vector3 Setting; 
    void FixedUpdate()
    {
        //Debug.Log(player.position);	
        transform.position = player.position + Setting;
	}
}
