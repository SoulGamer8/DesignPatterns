using System;
using UnityEngine;

namespace Nevermindever.ObjectPool.Bullet {
    public class BulletMove : MonoBehaviour {
        private Vector2 _target;

        public void Initialization(Vector2 target)
        {
            _target = target;
        }
        
        private void Update()
        {
            transform.position = Vector2.MoveTowards(transform.position, _target, 0.1f);
            if(Vector2.Distance(transform.position, _target) < 0.1f)
                Destroy(gameObject);
        }
    }
}
