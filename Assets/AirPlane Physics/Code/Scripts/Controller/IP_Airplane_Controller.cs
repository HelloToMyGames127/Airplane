using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vishal
{
    public class IP_Airplane_Controller : IP_BaseRigidbody_Controller
    {

        #region variables
        [Header("Base Airplane Properties")]
        public IP_BaseAirplane_Input input;
        public Transform centerOfGravity;

        [Tooltip("Weight is in LBS")]
        public float airplaneweight = 800f;
        #endregion

        #region Constants
        private float poundsTokg = 0.453592f;
        #endregion

        #region Buildin methods
        protected override void Start()
        {
            base.Start();
            float massinkg = airplaneweight * poundsTokg;
            if (rb)
            {
                rb.mass = massinkg;
            }
            if (centerOfGravity)
            {
                rb.centerOfMass = centerOfGravity.localPosition;
            }
        }
        #endregion

        #region Buildin methods
        protected override void HandlePhysics()
        {
            HandleEngines();
            HandleAerodynamics();
            HandleSteering();
            HandleBrakes();
            HandleAltitude();
        }

        void HandleEngines()
        {

        }

        void HandleAerodynamics()
        {

        }

        void HandleSteering()
        {

        }

        void HandleBrakes()
        {

        }

        void HandleAltitude()
        {

        }
        #endregion
    }
}

