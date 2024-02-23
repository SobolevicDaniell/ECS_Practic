using Leopotam.Ecs;

namespace Ecs
{
    sealed class PlayerJumpSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerTag, GroundCheckSphereComponent, JumpComponent, JumpEvent> _filter = null;

        public void Run()
        {
            foreach (var i in _filter)
            {
                ref var entity = ref _filter.GetEntity(i);
                ref var groundCheck = ref _filter.Get2(i);
                ref var jumpComponent = ref _filter.Get3(i);
                ref var movable = ref entity.Get<MovableComponent>();
                //ref var velocity = ref movable.
            }
        }
    }
}