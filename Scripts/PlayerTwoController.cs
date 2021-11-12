using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerTwoController : MonoBehaviour
{
    //-----------------------------------External
    Inputs inputs;
    public WheelCollider frontR, frontL;
    public WheelCollider backR, backL;
    public Transform pos;
    public Rigidbody body;
    //-----------------------------------

    //Car settings
    public float motorForce = 50;
    public float maxSteerAngle = 20;

    //Start
    public static bool start;
    //Finish
    bool finish;
    
    //Input values (Car)
    float gas = 0;
    float back = 0;
    float right = 0;
    float left = 0;

    //Input values (Camera)
    float cright = 0;
    float cleft = 0;
    float cup = 0;
    float cdown = 0;
    float cback = 0;

    //Boost variables
    bool boost;
    public static float boostAmount = 0;

    //Checkpoints
    int currentCheckpoint = 0;
    int laps = 0;

    //Reset state
    public static bool reset = false;

    //Scene enabled
    bool enabled;

    //Threads
    Thread boostC;
    Thread finishC;

    private void Awake()
    {
        //Setup Inputs
        inputs = new Inputs();
        inputs.PlayerTwo.Gas.performed += ctx => gas = ctx.ReadValue<float>();
        inputs.PlayerTwo.Back.performed += ctx => back = ctx.ReadValue<float>();
        inputs.PlayerTwo.Gas.canceled += ctx => gas = 0;
        inputs.PlayerTwo.Back.canceled += ctx => back = 0;

        inputs.PlayerTwo.Left.performed += ctx => right = ctx.ReadValue<float>();
        inputs.PlayerTwo.Right.performed += ctx => left = ctx.ReadValue<float>();
        inputs.PlayerTwo.Left.canceled += ctx => right = 0;
        inputs.PlayerTwo.Right.canceled += ctx => left = 0;

        inputs.PlayerTwo.cLeft.performed += ctx => cleft = ctx.ReadValue<float>();
        inputs.PlayerTwo.cRight.performed += ctx => cright = ctx.ReadValue<float>();
        inputs.PlayerTwo.cUp.performed += ctx => cup = ctx.ReadValue<float>();
        inputs.PlayerTwo.cDown.performed += ctx => cdown = ctx.ReadValue<float>();
        inputs.PlayerTwo.cBack.performed += ctx => cback = 5f;
        inputs.PlayerTwo.cLeft.canceled += ctx => cleft = 0;
        inputs.PlayerTwo.cRight.canceled += ctx => cright = 0;
        inputs.PlayerTwo.cUp.canceled += ctx => cup = 0;
        inputs.PlayerTwo.cDown.canceled += ctx => cdown = 0;
        inputs.PlayerTwo.cBack.canceled += ctx => cback = 0;

        inputs.PlayerTwo.Reset.performed += ctx => resetToPoint();
        inputs.PlayerTwo.Boost.performed += ctx => applyBoost();
        inputs.PlayerTwo.Boost.canceled += ctx => stopBoost();

        ////Set start to false
        start = false;
        finish = false;

        //Enabled to true
        enabled = true;

        //Reset boost amount
        boostAmount = 0;
    }

    private void FixedUpdate()
    {
        //Check if start
        if (start)
        {
            //Check if in reset mode
            if (!reset)
            {
                //Call functions
                Accelerate();
                Steer();

                //Set camera offset
                Camera2.off2 = new Vector3((cright - cleft), (cup - cdown), cback * 2);
            }
            else
            {
                //Reset motor speed
                frontR.motorTorque = 0;
                frontL.motorTorque = 0;
                backR.motorTorque = 0;
                backL.motorTorque = 0;
                frontR.brakeTorque = 10000;
                frontL.brakeTorque = 10000;
                backR.brakeTorque = 10000;
                backL.brakeTorque = 10000;
            }

            //Check if player can boost
            if (boost && boostAmount > 0)
            {
                body.AddForce(transform.forward * 10, ForceMode.Acceleration);
            }

            //Check if player needs reset
            checkForReset();
        }

        //Back to mainscreen if finish
        if (finish)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Start()
    {
        //New thread for boost counter
        boostC = new Thread(boostCounter);
        boostC.Start();
    }

    public async void boostCounter()
    {
        while (enabled)
        {
            //Check if start
            if (start)
            {
                //Check if count up or down
                if (!boost && boostAmount < 100)
                {
                    boostAmount++;
                    Thread.Sleep(100);
                }
                if (boost && boostAmount > 0)
                {
                    boostAmount--;
                    Thread.Sleep(30);
                }
            }   
        }
    }

    public void Accelerate()
    {
        //Add acceleration
        frontR.motorTorque = motorForce * (gas - back);
        frontL.motorTorque = motorForce * (gas - back);
        backR.motorTorque = motorForce * (gas - back);
        backL.motorTorque = motorForce * (gas - back);
    }

    public void Steer()
    {
        //Steer
        frontR.steerAngle = maxSteerAngle * (left - right);
        frontL.steerAngle = maxSteerAngle * (left - right);
    }

    public void checkForReset()
    {
        //Check if car y position < 300
        if (pos.position.y < 300)
        {
            //Set reset mode to true
            reset = true;

            //Check if car y position < 200
            if (pos.position.y < 200)
            {
                //Call function
                resetToPoint();
            }
        }
    }

    public void resetToPoint()
    {
        //Check if start
        if (!start) { return; }

        //Reset velocity and angular velocity
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;

        //Checks current checkpoint and sets rotation and posistion for respawn
        if (currentCheckpoint == 0)
        {
            pos.eulerAngles = new Vector3(0, -53, 0);
            pos.position = new Vector3(-452, 310, 40);
        }
        if (currentCheckpoint == 1)
        {
            pos.eulerAngles = new Vector3(0, -95, 0);
            pos.position = new Vector3(-1046, 310, 285);
        }
        if (currentCheckpoint == 2)
        {
            pos.eulerAngles = new Vector3(0, -150, 0);
            pos.position = new Vector3(-1763, 310, -280);
        }
        if (currentCheckpoint == 3)
        {
            pos.eulerAngles = new Vector3(0, -230, 0);
            pos.position = new Vector3(-1734, 310, -1786);
        }
        if (currentCheckpoint == 4)
        {
            pos.eulerAngles = new Vector3(0, -260, 0);
            pos.position = new Vector3(-488, 310, -1020);
        }
        if (currentCheckpoint == 5)
        {
            pos.eulerAngles = new Vector3(0, -310, 0);
            pos.position = new Vector3(421, 310, -1681);
        }
        if (currentCheckpoint == 6)
        {
            pos.eulerAngles = new Vector3(0, 30, 0);
            pos.position = new Vector3(1140, 310, -700);
        }
        if (currentCheckpoint == 7)
        {
            pos.eulerAngles = new Vector3(0, -10, 0);
            pos.position = new Vector3(1932, 310, 8);
        }
        if (currentCheckpoint == 8)
        {
            pos.eulerAngles = new Vector3(0, -120, 0);
            pos.position = new Vector3(1157, 310, 975);
        }
        
        //Set brakeTorque to 0
        frontR.brakeTorque = 0;
        frontL.brakeTorque = 0;
        backR.brakeTorque = 0;
        backL.brakeTorque = 0;

        //Set reset mode to false
        reset = false;
    }

    void applyBoost()
    {
        //Set boost mode to true
        boost = true;
    }

    void stopBoost()
    {
        //Set boost mode to false
        boost = false;
    }

    //Checks if car goes trough checkpoint
    private void OnTriggerEnter(Collider c)
    {
        //Check if start
        if (!start) { return; }

        if (c.name.Equals("checkpoint1"))
        {
            if (currentCheckpoint == 0)
            {
                currentCheckpoint = 1;
            }
        }
        if (c.name.Equals("checkpoint2"))
        {
            if (currentCheckpoint == 1)
            {
                currentCheckpoint = 2;
            }
        }
        if (c.name.Equals("checkpoint3"))
        {
            if (currentCheckpoint == 2)
            {
                currentCheckpoint = 3;
            }
        }
        if (c.name.Equals("checkpoint4"))
        {
            if (currentCheckpoint == 3)
            {
                currentCheckpoint = 4;
            }
        }
        if (c.name.Equals("checkpoint5"))
        {
            if (currentCheckpoint == 4)
            {
                currentCheckpoint = 5;
            }
        }
        if (c.name.Equals("checkpoint6"))
        {
            if (currentCheckpoint == 5)
            {
                currentCheckpoint = 6;
            }
        }
        if (c.name.Equals("checkpoint7"))
        {
            if (currentCheckpoint == 6)
            {
                currentCheckpoint = 7;
            }
        }
        if (c.name.Equals("checkpoint8"))
        {
            if (currentCheckpoint == 7)
            {
                currentCheckpoint = 8;
            }
        }
        if (c.name.Equals("finish"))
        {
            if (currentCheckpoint == 8)
            {
                start = false;
                PlayerOneController.start = false;
                PlayerPrefs.SetInt("P2WINS", PlayerPrefs.GetInt("P2WINS") + 1);
                finishC = new Thread(finishCounter);

                MiniMapHandler.started = false;
                int sec = Mathf.RoundToInt(MiniMapHandler.time);
                int min = MiniMapHandler.min;

                int bsec = PlayerPrefs.GetInt("BEST_SEC");
                int bmin = PlayerPrefs.GetInt("BEST_MIN");

                //Check if new best
                if ((sec + min * 60 < bsec + bmin*60) || (bsec == 0 && bmin == 0))
                {
                    PlayerPrefs.SetInt("BEST_SEC", sec);
                    PlayerPrefs.SetInt("BEST_MIN", min);
                }

                finishC.Start();
            }
        }
    }

    //Countdown when finish
    async void finishCounter()
    {
        Thread.Sleep(4000);
        finish = true;
    }

    //Input System
    private void OnEnable()
    {
        inputs.PlayerTwo.Enable();
    }
    private void OnDisable()
    {
        inputs.PlayerTwo.Disable();
        enabled = false;

        //Close threads
        boostC.Abort();
        finishC.Abort();
    }
}
