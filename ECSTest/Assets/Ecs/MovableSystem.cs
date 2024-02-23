using Leopotam.Ecs;

namespace Ecs
{
    sealed class MovableSystem : IEcsRunSystem
    {
        private readonly EcsWorld _world = null;

        private readonly EcsFilter<ModelComponent, MovableComponent, DirectionComponent> movableFilter = null;
        
        public void Run()
        {
            foreach (var i in movableFilter)
            {
                ref var modelComponent = ref movableFilter.Get1(i);
                ref var movableComponent = ref movableFilter.Get2(i);
                ref var directionComponent = ref movableFilter.Get3(i);

                ref var direction = ref directionComponent.Dierection;
                ref var transform = ref modelComponent.modelTransform;
                ref var chatracterController = ref movableComponent.characterController;

                ref var speed = ref movableComponent.speed;

                var rawDirection = (transform.right * direction.x) + (transform.forward * direction.z);

                chatracterController.Move(rawDirection * speed);
            }
        }
    }
}