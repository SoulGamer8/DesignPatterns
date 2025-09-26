using System;
using System.Collections.Generic;
using Nevermindever.Enemy.Data;
using Nevermindever.Enemy.Logic;
using UnityEngine;

namespace Nevermindever.Enemy.AbstractFactory {
    public class EnemyAbstractFactory : IEnemyFactory {
        private readonly Dictionary<Type, IEnemyFactory> _factories = new();
        
        public void RegisterFactory<TData>(IEnemyFactory factory) where TData : EnemyData {
            _factories[typeof(TData)] = factory;
        }
        
        public EnemyComponent CreateEnemy(EnemyData data, Vector3 position, Quaternion rotation) {
            Type dataType = data.GetType();

            if (_factories.TryGetValue(dataType, out IEnemyFactory factory)) {
                return factory.CreateEnemy(data, position, rotation);
            }

            throw new ArgumentException($"No factory registered for data type: {dataType}");
        }
    }
}
