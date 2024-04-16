using System;
using UnityEngine;
using System.Collections.Generic;

namespace TwoLesson
{
    public class PlayerState : MonoBehaviour
    {
        private Dictionary<Type, IPlayerBehavior> _behaviorsMap;

        private IPlayerBehavior _behaviorCurrentState;

        private void Start()
        {
            InitBehaviors();
            SetBehaviorByDefault();
        }

        private void InitBehaviors()
        {
            _behaviorsMap = new Dictionary<Type, IPlayerBehavior>();

            _behaviorsMap[typeof(PlayerBehaviorActive)] = new PlayerBehaviorActive();
            _behaviorsMap[typeof(PlayerBehaviorIdle)] = new PlayerBehaviorIdle();
            _behaviorsMap[typeof(PlayerBehaviorAggressive)] = new PlayerBehaviorAggressive();
        }

        private void SetBehavior(IPlayerBehavior newBehavior)
        {
            if (_behaviorCurrentState != null)
                _behaviorCurrentState.Exit();

            _behaviorCurrentState = newBehavior;
            _behaviorCurrentState.Enter();
        }

        private void SetBehaviorByDefault() => SetBehaviorIdle();

        private IPlayerBehavior GetBehavior<T>() where T : IPlayerBehavior
        {
            var type = typeof(T);
            return _behaviorsMap[type];
        }

        private void Update()
        {
            if (_behaviorCurrentState != null)
                _behaviorCurrentState.Update();
        }

        public void SetBehaviorActive()
        {
            var behavior = GetBehavior<PlayerBehaviorActive>();
            SetBehavior(behavior);
        }

        public void SetBehaviorIdle()
        {
            var behavior = GetBehavior<PlayerBehaviorIdle>();
            SetBehavior(behavior);

        }

        public void setBehaviorAggressive()
        {
            var behavior = GetBehavior<PlayerBehaviorAggressive>();
            SetBehavior(behavior);
        }
    }
}