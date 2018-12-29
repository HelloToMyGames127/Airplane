using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vishal
{
    public class IP_Airplane_Propellers : MonoBehaviour
    {
        #region Variables
        [Header("Propeller Properties")]
        public float minQuadRPMs = 300f;
        public float minTextureSwap = 600f;
        public GameObject mainProp;
        public GameObject blurredProp;
        [Header("Material Properties")]
        public Material blurredPropeMat;
        public Texture2D blurLevel1;
        public Texture2D blurLevel2;
        #endregion

        #region Buildin Methods
        void Start()
        {
            if (mainProp && blurredProp)
            {
                HandleSwapping(0f);
            }
        }
        #endregion

        #region Custom Methods
        public void HandlePropeller(float currentRPM)
        {
            // Calculate degree per second
            float dps = ((currentRPM * 360f) / 60f) * Time.deltaTime;

            // Rotate the propeller group
            transform.Rotate(Vector3.forward, dps);

            // Handle propeller swapping
            if(mainProp && blurredProp)
            {
                HandleSwapping(currentRPM);
            }
        }

        void HandleSwapping(float currentRPM)
        {
            if(currentRPM > minQuadRPMs)
            {
                blurredProp.SetActive(true);
                mainProp.SetActive(false);
                if(blurredPropeMat)
                {
                    if(currentRPM > minTextureSwap && blurLevel1 && blurLevel2)
                    {
                        blurredPropeMat.SetTexture("_MainTex", blurLevel2);
                    }
                    else
                    {
                        blurredPropeMat.SetTexture("_MainTex", blurLevel1);
                    }
                }
            }
            else
            {
                blurredProp.SetActive(false);
                mainProp.SetActive(true);
            }
        }
        #endregion
    }
}

