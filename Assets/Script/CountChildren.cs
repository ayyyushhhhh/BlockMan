using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CountChildren : MonoBehaviour
{
    [SerializeField] private GameObject lostPanel;
    [SerializeField] private GameObject upperBody;
    [SerializeField] private GameObject leftElbow;
    [SerializeField] private GameObject rightElbow;
    [SerializeField] private GameObject leftArm;
    [SerializeField] private GameObject rightArm;
    [SerializeField] [CanBeNull] private GameObject leftKnee;
    [SerializeField] [CanBeNull] private GameObject rightKnee;
    [SerializeField] private GameObject lowerBody;
    [SerializeField] [CanBeNull] private GameObject rightLeg;
    [SerializeField] [CanBeNull] private GameObject leftLeg;
    [SerializeField] private GameObject rightFoot;
    [SerializeField] private GameObject leftFoot;
    [SerializeField] private GameObject leftHand;
    [SerializeField] private GameObject rightHand;
    [SerializeField] private GameObject head;           
    
    [SerializeField] private int upperBodyCount;
    [SerializeField] private int leftElbowCount;
    [SerializeField] private int rightElbowCount;
    [SerializeField] private int leftArmCount;
    [SerializeField] private int rightArmCount;
    [SerializeField] private int leftKneeCount;
    [SerializeField] private int rightKneeCount;
    [SerializeField] private int lowerBodyCount;
    [SerializeField] private  int rightLegCount;
    [SerializeField] private int leftLegCount;
    [SerializeField] private int rightFootCount;
    [SerializeField] private int leftFootCount;
    [SerializeField] private int leftHandCount;
    [SerializeField] private int rightHandCount;
    [SerializeField] private int headCount;
    void Start()
    {
        /*upperBodyCount = upperBody.transform.childCount;
        leftElbowCount = leftElbow.transform.childCount;
        rightElbowCount = rightElbow.transform.childCount;
        leftArmCount = leftArm.transform.childCount;
        rightArmCount = rightArm.transform.childCount;
        lowerBodyCount = lowerBody.transform.childCount;
        rightLegCount = rightLeg.transform.childCount;
        leftLegCount = leftLeg.transform.childCount;
        rightFootCount = rightFoot.transform.childCount;
        leftFootCount = leftFoot.transform.childCount;
        leftHandCount = leftHand.transform.childCount;
        rightHandCount = rightHand.transform.childCount;
        headCount = head.transform.childCount;*/
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (upperBody.transform.childCount==0 &&
            (leftElbow == null || leftElbow.transform.childCount==0)&&
            (rightElbow == null|| rightElbow.transform.childCount==0) &&
            (leftArm == null|| leftArm.transform.childCount==0) &&
            (rightArm == null|| rightArm.transform.childCount==0) &&
            (leftKnee == null|| leftKnee.transform.childCount==0) &&
           ( rightKnee == null || rightKnee.transform.childCount==0)&&
            (lowerBody.transform.childCount==0 || lowerBody.transform.childCount==0)&&
            (rightLeg == null || rightLeg.transform.childCount==0)&&
            (leftLeg == null || leftLeg.transform.childCount==0)&&
            rightFoot == null &&
            leftFoot == null &&
            (leftHand == null|| leftHand.transform.childCount==0) &&
            (rightHand == null|| rightHand.transform.childCount==0) &&
            head == null)
        {   
            lostPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if (rightFoot != null && leftFoot != null)
        {
            transform.position = new Vector3(transform.position.x, 3.05f, transform.position.z);
        }
        else if (leftKnee ==null&&
            rightKnee==null)
        {
            transform.position = new Vector3(transform.position.x, 1.92f, transform.position.z);
        }
        
        else if ((leftLeg ==null&&
            rightLeg==null))
        {
            transform.position = new Vector3(transform.position.x, 1.38f, transform.position.z);
        }
        
        else if (upperBody.transform.childCount == 1 && lowerBody.transform.childCount == 0)
        {
            transform.position = new Vector3(transform.position.x, 0.70f, transform.position.z);
        }
        else if (upperBody.transform.childCount == 0 && lowerBody.transform.childCount == 0)
        {
            transform.position = new Vector3(transform.position.x, 0.51f, transform.position.z);
        }

        /*upperBodyCount = upperBody.transform.childCount;
        leftElbowCount = leftElbow.transform.childCount;
        rightElbowCount = rightElbow.transform.childCount;
        leftArmCount = leftArm.transform.childCount;
        rightArmCount = rightArm.transform.childCount;
        leftKneeCount = leftKnee.transform.childCount;
        rightKneeCount = rightKnee.transform.childCount;
        lowerBodyCount = lowerBody.transform.childCount;
        rightLegCount = rightLeg.transform.childCount;
        leftLegCount = leftLeg.transform.childCount;
        rightFootCount = rightFoot.transform.childCount;
        leftFootCount = leftFoot.transform.childCount;
        leftHandCount = leftHand.transform.childCount;
        rightHandCount = rightHand.transform.childCount;
        headCount = head.transform.childCount;*/
    }
}
