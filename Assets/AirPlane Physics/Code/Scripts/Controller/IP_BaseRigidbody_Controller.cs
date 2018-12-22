using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vishal
{
    [RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
    public class IP_BaseRigidbody_Controller : MonoBehaviour
    {
        #region private variables
        protected Rigidbody rb;
        protected AudioSource aSource;
        #endregion

        #region Buildin methods
        // Use this for initialization
        protected virtual void Start()
        {
            rb = GetComponent<Rigidbody>();
            aSource = GetComponent<AudioSource>();
            if (aSource)
            {
                aSource.playOnAwake = false;
            }
        }

        // FixedUpdate is called once per each frame
        void FixedUpdate()
        {
            if (rb)
            {
                HandlePhysics();
            }
        }
        #endregion

        #region Custom methods
        protected virtual void HandlePhysics() {}
        #endregion
    }
}

