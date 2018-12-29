using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vishal
{
    public class IP_Airplane_Engine : MonoBehaviour
    {
        #region variables
        [Header("Engine Properties")]
        public float maxPower = 200f;
        public float maxRPM = 2550f;
        public AnimationCurve powerCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

        [Header("Propellers")]
        public IP_Airplane_Propellers propeller;
        #endregion

        #region Buildin methods
        #endregion

        #region Custom methods
        public Vector3 CalculateForce(float throttle)
        {
            // Calculate power
            float finalThrottle = Mathf.Clamp01(throttle);
            finalThrottle = powerCurve.Evaluate(finalThrottle);

            // Calculate RPM
            float currentRPM = finalThrottle * maxRPM;
            if (propeller)
            {
                propeller.HandlePropeller(currentRPM);
            }

            // Create force
            float finalPower = finalThrottle * maxPower;
            Vector3 finalForce = transform.forward * finalPower;

            return finalForce;
        }
        #endregion
    }
}

