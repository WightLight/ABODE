namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;

    /// <summary>
    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    /// </summary>
    public class CardVisualizer : MonoBehaviour
    {
        /// <summary>
        /// The AugmentedImage to visualize.
        /// </summary>
        public AugmentedImage Image;
        
        /// <summary>
        /// An image to use for the card's background.
        /// </summary>
        public GameObject BackgroundImage;

        /// <summary>
        /// The Unity Update method.
        /// </summary>
        public void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                //BackgroundImage.SetActive(false);
                return;
            }

            float halfWidth = Image.ExtentX / 2;
            float halfHeight = Image.ExtentZ / 2;

            BackgroundImage.transform.localPosition =
                (halfWidth * Vector3.zero) + (halfHeight * Vector3.zero);
            // FrameLowerLeft.transform.localPosition =
            //     (halfWidth * Vector3.left) + (halfHeight * Vector3.back);
            // FrameLowerRight.transform.localPosition =
            //     (halfWidth * Vector3.right) + (halfHeight * Vector3.back);
            // FrameUpperLeft.transform.localPosition =
            //     (halfWidth * Vector3.left) + (halfHeight * Vector3.forward);
            // FrameUpperRight.transform.localPosition =
            //     (halfWidth * Vector3.right) + (halfHeight * Vector3.forward);

            BackgroundImage.SetActive(true);
        }
    }
}
