using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     [SerializeField]
    private int speed;
    [SerializeField]
public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
     playerAnimator=GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        speed=Input.GetAxisRaw("Horizontal");
        Debug.log(speed);
          
}
}
