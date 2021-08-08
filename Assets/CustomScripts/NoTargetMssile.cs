using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTargetMssile : MonoBehaviour
{
    public float Speed = 2.0f;
    public Vector3 dir;
    public float lifetime = 15.0f;
    public float delay = 1.0f;
    // Start is called before the first frame update
    public virtual void Start()
    {  
        if(dir ==null) dir= new Vector3(0,-1,0);
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
