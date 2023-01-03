using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int RunningHash;
    int LeftHash;
    int RightHash;
    int JumpRunHash;
    int RunLeftHash;
    int RunRightHash;
    int JumpHash;
    int TruotHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        RunningHash = Animator.StringToHash("Running");
        LeftHash = Animator.StringToHash("Left");
        RightHash = Animator.StringToHash("Right");
        JumpRunHash = Animator.StringToHash("JumpRun");
        RunLeftHash = Animator.StringToHash("RunLeft");
        RunRightHash = Animator.StringToHash("RunRight");
        JumpHash = Animator.StringToHash("Jump");
        TruotHash = Animator.StringToHash("Truot");

    }

    // Update is called once per frame
    void Update()
    {
        bool Running = animator.GetBool(RunningHash);
        bool Left = animator.GetBool(LeftHash); 
        bool Right = animator.GetBool(RightHash);
        bool JumpRun = animator.GetBool(JumpRunHash);
        bool Jump = animator.GetBool(JumpHash);
        bool RunLeft = animator.GetBool(RunLeftHash);
        bool RunRight = animator.GetBool(RunRightHash);
        bool Truot = animator.GetBool(TruotHash);
        bool RunPressed= Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool jumpPressed = Input.GetKey("space");
        bool truotPressed = Input.GetKey("v");
        //truot
        /*if(!Truot && truotPressed && RunPressed)
        {
            animator.SetBool(TruotHash, true);
        }
        if (Truot && !truotPressed || !RunPressed)
        {
            animator.SetBool(TruotHash, false);
        }*/
        //Nhay tai cho
        if (!Jump && jumpPressed && !RunPressed)
        {
            animator.SetBool(JumpHash, true);
        }
        if (Jump && !jumpPressed && !RunPressed)
        {
            animator.SetBool(JumpHash, false);
        }
        //Run
        if (!Running && RunPressed)
        {
            animator.SetBool(RunningHash, true);
        }
        if (Running && !RunPressed)
        {
            animator.SetBool(RunningHash, false);
        }
        //Dung yen re trai
        if(!Left && leftPressed && !RunPressed)
        {
            animator.SetBool(LeftHash, true);
        }
        if (Left && !leftPressed && ! RunPressed)
        {
            animator.SetBool(LeftHash, false);
        }
        //dung yen re phai
        if (!Right && rightPressed && !RunPressed)
        {
            animator.SetBool(RightHash, true);
        }
        if (Right && !rightPressed && !RunPressed)
        {
            animator.SetBool(RightHash, false);
        }
        //chay va nhay
        if (!JumpRun && RunPressed && jumpPressed )
        {
            animator.SetBool(JumpRunHash, true);
        }
        if (JumpRun && !RunPressed || !jumpPressed)
        {
            animator.SetBool(JumpRunHash, false);
        }
        
        //Chay r? ph?i
        if(!RunRight && RunPressed && rightPressed)
        {
            animator.SetBool(RunRightHash, true);
        }
        if(RunRight && !RunPressed || !rightPressed)
        {
            animator.SetBool(RunRightHash, false);
        }
        //chay re trai
        if(!RunLeft && RunPressed && leftPressed)
        {
            animator.SetBool(RunLeftHash, true);
        }
        if(RunLeft && !RunPressed || !leftPressed)
        {
            animator.SetBool(RunLeftHash, false);
        }

    }
}
