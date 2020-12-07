using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class NewPlayer : MonoBehaviour, IDragHandler
{
    void Start(){

    }

    void Update() {

        if(transform.localPosition.y > 0)
        {
            return;
        
        }
        transform.Translate(new Vector3(0,0.7,0) * Time.deltaTime);
        
    }
}
