using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTargetMissle : MonoBehaviour
{
    public Transform target;
    public float Speed;
    private Vector2 destination;
    private Vector3 dir;
    public float lifetime = 15.0f;
    public float delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {   if(target ==null)
        target = GameObject.FindGameObjectWithTag("Player").transform;
        // destination = new Vector2(target.transform.position.x,target.transform.position.y);
        //get direction to target no magnitude
        dir = (target.transform.position - this.gameObject.transform.position).normalized;
        //rotate look at target position
        this.transform.LookAt(target);
        // get angle between object
        // Vector3.Angle(target.transform.position,this.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        delay-=Time.deltaTime;
        lifetime-=Time.deltaTime;
        if(delay>0)return;
        if(lifetime <0)Destroy(this.gameObject);
        //this make object move toward exactly point target
        // this.transform.position =Vector2.MoveTowards(GetCurrentPosition(),destination,Speed*Time.deltaTime);

        this.transform.position = this.transform.position+(dir * Time.deltaTime * Speed);
    }
    Vector2 GetCurrentPosition(){
        return new Vector2(this.transform.position.x,this.transform.position.y);
    }
}
