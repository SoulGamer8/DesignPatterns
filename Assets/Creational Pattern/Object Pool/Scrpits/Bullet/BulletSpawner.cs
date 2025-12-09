using UnityEngine;

namespace Nevermindever.ObjectPool.Bullet{
    public class BulletSpawner : MonoBehaviour {
       [SerializeField] private GameObject _bulletPrefab;
       [SerializeField] private Transform _playerTransform;
       // So better make this class Singalton but i dont do that


       public void SpawnBullet(Vector2 target) {
           GameObject bullet = Instantiate(_bulletPrefab, _playerTransform.position, _playerTransform.rotation);
           if(bullet.TryGetComponent<BulletMove>(out BulletMove bulletMove)) 
               bulletMove.Initialization(target);
       }
       
       
    }
}
