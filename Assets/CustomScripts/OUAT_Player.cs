using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OUAT_Player : MonoBehaviour
{
    public Dictionary<System.Int32, System.Action> OUAT_List = new Dictionary<System.Int32, System.Action>();
    private float OUAT_SkillGauge = 0;
    private int indxSkill = 0;
    void Start()
    {
        OUAT_List.Add(1,()=>ShootFire());
        OUAT_List.Add(2,()=>RedAttack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void ShootFire(){
        Debug.Log("ShootFire");
    }
    private void RedAttack(){
        Debug.Log("ShootFire");
        OUAT_SkillGauge+=1;
    }

    public void useSkill(){
        OUAT_List[indxSkill]();
    }

    public void ChangeSkill(int i){
        indxSkill = Mathf.Clamp(indxSkill+i,0,2);
    }
}
