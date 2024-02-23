using System;
using Leopotam.Ecs;
using UnityEngine;

namespace Ecs
{
    [Serializable]
    public struct ModelComponent
    {
        public Transform modelTransform;
        public float velocity;
    }
}