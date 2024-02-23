using System;
using UnityEngine;

namespace Ecs
{
    [Serializable]
    public struct GroundCheckSphereComponent
    {
        public LayerMask groundMask;
        public Transform groundCheckSphere;
        public float groundDistance;
        public bool isGrounded;
    }
}