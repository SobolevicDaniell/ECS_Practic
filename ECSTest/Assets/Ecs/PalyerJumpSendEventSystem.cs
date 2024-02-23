using Leopotam.Ecs;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

namespace Ecs
{
    sealed class PalyerJumpSendEventSystem : IEcsRunSystem
    {

        private readonly EcsFilter<PlayerTag, JumpComponent> _filter = null;
        
        public void Run()
        {
            if (!Input.GetKeyDown(KeyCode.Space)) return;

            foreach (var i in _filter)
            {
                ref var entity = ref _filter.GetEntity(i);
                entity.Get<JumpEvent>();
            }
        }
    }
}