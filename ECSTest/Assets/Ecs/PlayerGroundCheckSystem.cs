using Leopotam.Ecs;
using UnityEngine;

namespace Ecs
{
    sealed class PlayerGroundCheckSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerTag, GroundCheckSphereComponent> _filter = null;
        
        public void Run()
        {
            foreach (var i in _filter)
            {
                ref var grounCheck = ref _filter.Get2(i);

                grounCheck.isGrounded =
                    Physics.CheckSphere(grounCheck.groundCheckSphere.position, grounCheck.groundDistance,
                        grounCheck.groundMask);
            }
        }
    }
}