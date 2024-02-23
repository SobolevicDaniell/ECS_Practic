using System;
using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

namespace Ecs
{
    public class EcsGameStartup : MonoBehaviour
    {
        private EcsWorld _world;
        private EcsSystems _systems;


        private void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);

            _systems.ConvertScene();
        
            AddInjections();
            AddOneFrames();
            AddSystems();
        
            _systems.Init();
        }

        private void AddSystems()
        {
            _systems.
                Add(new PlayerInpusSystems());
        }

        private void AddInjections()
        {
        
        }

        private void AddOneFrames()
        {
            _systems.Add(new MovableSystem())
                .OneFrame<JumpEvent>();
        }


        private void Update()
        {
            _systems.Run();
        }

        private void OnDestroy()
        {
            if (_systems == null)
            {
                _systems.Destroy();
                _systems = null;
                _world.Destroy();
                _world = null;
            }
        
        }
    }
}

