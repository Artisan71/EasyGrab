using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using easyInputs;

public class EasyGrab : MonoBehaviour
{
    /*Copyright © [.artisan71]

    All rights reserved.

    This script and its content are protected under copyright law.This script or any portion thereof may not be reproduced or used in any manner whatsoever without the express written permission of the copyright owner, except for the use of brief quotations in a review.

    Unauthorized use, reproduction, or distribution of this script, or any part thereof, may result in severe civil and criminal penalties, and will be prosecuted to the maximum extent possible under the law.

    DO NOT DELETE THIS FROM THE SCRIPT!!!

    For permission requests, contact:
    [Artisan71]
    [.artisan71]*/
    [Header("You can do left or right hand controllers")]
    public GameObject Controller;
    public GameObject ObjectToGrab;
    public AudioSource PickupSound;
    private bool CanGrab;

    void OnTriggerEnter(Collider other)
    {
        CanGrab = true;
    }
    void OnTriggerExit(Collider other)
    {
        CanGrab = false;
    }


    void Update()
    {
        if (CanGrab == true)
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                ObjectToGrab.transform.position = Controller.transform.position;
                ObjectToGrab.transform.rotation = Controller.transform.rotation;
                PickupSound.Play();
            }
        }

    }
}
