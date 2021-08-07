using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]private Animator ani;
    void Start()
    {
        ani = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void PlayerAction() { 
        ani.SetTrigger("action");
    
    }
}
