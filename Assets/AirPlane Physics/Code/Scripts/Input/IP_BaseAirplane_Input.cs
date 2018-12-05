using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vishal
{
    public class IP_BaseAirplane_Input : MonoBehaviour
    {
        #region Variables
        protected float pitch = 0f; // go up and down (from -1 to 1)
        protected float roll = 0f; // roll left and right (from -1 to 1)
        protected float yaw = 0f; // turn left and right with the rudder (from -1 to 1)
        protected float throttle = 0f; // how much gas are giving the airplane (from 0 to 1)

        public KeyCode brakeKey = KeyCode.Space;
        protected float brake = 0f;

        protected int flaps = 0;
        public int maxFlapIncrements = 2;
        #endregion

        #region Properties
        public float Pitch
        {
            get {return pitch; }
        }

        public float Roll
        {
            get { return roll; }
        }

        public float Yaw
        {
            get { return yaw; }
        }

        public float Throttle
        {
            get { return throttle; }
        }

        public float Flaps
        {
            get { return flaps; }
        }

        public float Brake
        {
            get { return brake; }
        }
        #endregion

        #region Buildin Methods
        // Use this for initialization
        void Start(){ }

        // Update is called once per frame
        void Update()
        {
            HandleInput();
        }
        #endregion

        #region Custom Methods

        protected virtual void HandleInput()
        {
            //Process Main control inputs
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");
            yaw = Input.GetAxis("Yaw");
            throttle = Input.GetAxis("Throttle");

            //Process Brake inputs
            brake = Input.GetKey(brakeKey) ? 1f : 0f;

            //Process Flap inputs
            if (Input.GetKeyDown(KeyCode.F))
            {
                flaps += 1;
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                flaps -= 1;
            }

            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrements);
        }

        #endregion
    }
}

