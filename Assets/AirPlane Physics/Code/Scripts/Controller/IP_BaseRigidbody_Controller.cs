using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vishal
{
    [RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
    public class IP_BaseRigidbody_Controller : MonoBehaviour
    {
        #region private variables
        private Rigidbody rb;
        private AudioSource aSource;
        #endregion

        #region Buildin methods
        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            aSource = GetComponent<AudioSource>();
            if (aSource)
            {
                aSource.playOnAwake = false;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (rb)
            {
                HandlePhysics();
            }
        }
        #endregion

        #region Custom methods
        protected virtual void HandlePhysics() { }
        #endregion
    }
}

