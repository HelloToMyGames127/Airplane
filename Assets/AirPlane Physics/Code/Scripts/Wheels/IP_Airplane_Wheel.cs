using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vishal
{
    [RequireComponent(typeof(WheelCollider))]
    public class IP_Airplane_Wheel : MonoBehaviour
    {
        #region variables
        private WheelCollider wheelCol;
        #endregion

        #region Buildin methods
        // Use this for initialization
        void Awake()
        {
            wheelCol = GetComponent<WheelCollider>();
        }
        #endregion

        #region Custom methods
        public void InitWheel()
        {
            if (wheelCol)
            {
                wheelCol.motorTorque = 0.0000000000000000001f;
                print("init wheels");
            }
        }
        #endregion
    }

}
