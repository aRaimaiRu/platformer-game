using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BTAI;
using UnityEngine.Events;
using System;
using Gamekit2D;
using Random=UnityEngine.Random;
public class Alibaba : MonoBehaviour
{
     Root ai;
    private Animator animator;
    private Vector2 target;
    private SpriteRenderer sr;
    public Transform defaultPosition;
    public GameObject trail;
    Rigidbody2D rb;
    protected Vector2 m_MoveVector;
    public String c_state;
    // [Header("Audio")]
    // public AudioClip playerDeathClip;
    public bool Alive = true;
    public Transform AttackPoint1;
    public float Atk1_speed;
    public GameObject SandMissile;
    void Start()
   {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
}
    private void OnEnable() {
        animator = GetComponent<Animator>();
        SceneLinkedSMB<Alibaba>.Initialise(animator, this);
        ai = BT.Root();
        ai.OpenBranch(
            // BT.Trigger(animator, "Intro"),
            BT.Wait(1.0f),
            BT.While(isAlive).OpenBranch(
                BT.Trigger(animator, "idle"),
                BT.Wait(1.0f),
                BT.SetActive(trail,true),
                BT.Trigger(animator, "Attack"),
                BT.Wait(6.0f),
                BT.SetActive(trail,false),
                BT.Call(SpawnSandMissile)
            )


        );
        
    }
    // void PlayerDied(Damager d, Damageable da)
    // {
    //     BackgroundMusicPlayer.Instance.PushClip(playerDeathClip);
    // }
    // Update is called once per frame
    void Update()
    {
        ai.Tick();
    }
    void FixedUpdate()
    { 
        this.transform.position = new Vector3(this.transform.position.x+m_MoveVector.x,this.transform.position.y+m_MoveVector.y,0);
    }
    bool isAlive(){
        return Alive;
    }
    public void IncrementHorizontalMovement(float additionalHorizontalMovement)
    {
        m_MoveVector.x = additionalHorizontalMovement;
    }

    public void IncrementVerticalMovement(float additionalVerticalMovement)
    {
        m_MoveVector.y = additionalVerticalMovement;
    }
    public void SetMoveVector(Vector2 newMoveVector)
    {
        m_MoveVector = newMoveVector;
    }
    public void SetPosition(Vector2 newMoveVector)
    {
        this.transform.position = new Vector3(newMoveVector.x,newMoveVector.y,0);
    }
    public Vector2 getCurrentPosition(){
        return new Vector2(this.transform.position.x,this.transform.position.y);
    }

    public void SlashAttack(){
        Vector2 target = new Vector2(AttackPoint1.position.x,rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position,target,Atk1_speed*Time.deltaTime);
        rb.MovePosition(newPos);

    }
    public void FlipSlashAttack(){
        Vector2 target = new Vector2(defaultPosition.position.x,rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position,target,Atk1_speed*Time.deltaTime*3);
        rb.MovePosition(newPos);

    }
    public void SpawnSandMissile(){
        for(int i=0;i<3;i++){
            Vector3 buffer = new Vector3(this.transform.position.x+Random.Range(10,40)*0.1f,this.transform.position.y+Random.Range(10,40)*0.1f,0);
            Instantiate(SandMissile,buffer,Quaternion.identity);
        }

    }

}
