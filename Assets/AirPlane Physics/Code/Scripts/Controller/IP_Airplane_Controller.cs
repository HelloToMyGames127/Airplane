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

        [Header("Engines")]
        public List<IP_Airplane_Engine> engines = new List<IP_Airplane_Engine>();

        [Header("Wheels")]
        public List<IP_Airplane_Wheel> wheels = new List<IP_Airplane_Wheel>();
        #endregion

        #region Constants
        private float poundsTokilos = 0.453592f;
        #endregion

        #region Buildin methods
        protected override void Start()
        {
            base.Start();
            float finalMass = airplaneweight * poundsTokilos;
            if (rb)
            {
                rb.mass = finalMass;

                if (centerOfGravity)
                {
                    rb.centerOfMass = centerOfGravity.localPosition;
                }
            }
            if(wheels != null)
            {
                if(wheels.Count > 0)
                {
                    foreach(IP_Airplane_Wheel wheel in wheels)
                    {

                    }
                }
            }
        }
        #endregion

        #region Buildin methods
        protected override void HandlePhysics()
        {
            if (input)
            {
                HandleEngines();
                HandleAerodynamics();
                HandleSteering();
                HandleBrakes();
                HandleAltitude();
            }
          
        }

        void HandleEngines()
        {
            if (engines != null)
            {
                if (engines.Count > 0)
                {
                    foreach (IP_Airplane_Engine engine in engines)
                    {
                        engine.CalculateForce(input.Throttle);
                    }
                }
            }

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

