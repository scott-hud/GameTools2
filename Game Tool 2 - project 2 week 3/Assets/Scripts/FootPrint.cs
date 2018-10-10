using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrint : MonoBehaviour {
    [SerializeField] GameObject m_footprint;

    private Animator m_animator;
    private Transform m_RightFootPrintTransform;
    private Transform m_LeftFootTransform;

    private void Start()
    {
        m_animator = GetComponent<Animator>();

        m_RightFootPrintTransform = m_animator.GetBoneTransform(HumanBodyBones.RightFoot);
        m_LeftFootTransform = m_animator.GetBoneTransform(HumanBodyBones.LeftFoot);
    }
    public void MakeFootprint(int Scale)
    {
        Debug.Log("Footprint");
        if (Scale > 0){
            Instantiate(m_footprint, m_LeftFootTransform.position, m_LeftFootTransform.rotation); }
        else 
        {
            Instantiate(m_footprint, m_RightFootPrintTransform.position, m_RightFootPrintTransform.rotation);
        }
        
    }
}
