using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    public Animator anim;
    public string animName;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    //void Update () {
    //if ()
    // {
    //   
    // }
    //}
    //public GameObject TriggerCube;
    //public GameObject LapCompleteTrig;
    //public GameObject HalfLapTrig;
    //public GameObject Anim;


    //private void OnTriggerEnter()
    //{
        //Anim.SetActive(true);
       // TriggerCube.SetActive(false);
       // anim.Play("Horse");
        //LapCompleteTrig.SetActive(true);
        //HalfLapTrig.SetActive(false);
    //}

    public void PlayAnim(string animName)
    {
        anim.Play(animName);
    }
}