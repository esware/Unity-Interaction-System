using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    public class Pickable : InteractableBase
    {
        private Rigidbody Rigid;

        public bool isTake = false;
        [SerializeField] private Transform TakePos;
        [SerializeField] private float smooth = 5f;
        [SerializeField] private InteractionInputData InputData = null;

        private float xAngle = 0;
        private float yAngle = 0;
        private float zAngle = 0;

        private void Awake()
        {
            Rigid = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            GetOutline.SetOutlineDisable();

            if (isTake)
            {
                transform.parent = TakePos;
                Rigid.isKinematic = true;
                Rigid.useGravity = false;
                transform.position = Vector3.Lerp(transform.position, TakePos.position, smooth * Time.deltaTime);


                if (InputData.RotateX)
                {
                    xAngle += 90f;
                }

                if (InputData.RotateY)
                {
                    yAngle += 90f;
                }
                if (InputData.RotateZ)
                {
                    zAngle += 90f;
                }

                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(xAngle, yAngle, zAngle), smooth * Time.deltaTime);
            }

            if (!isTake)
            {
                transform.parent = null;
                Rigid.isKinematic = false;
                Rigid.useGravity = true;
            }
        }

        public override void Pick()
        {
            isTake = true;
        }

        public override void Release()
        {
            isTake = false;
           
        }
    }
}

