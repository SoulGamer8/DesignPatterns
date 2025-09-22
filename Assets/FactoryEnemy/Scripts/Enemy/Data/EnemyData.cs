using UnityEngine;

namespace Nevermindever.Enemy.Data{
    public class EnemyData : ScriptableObject{
       public string name;
       public Sprite sprite; // we can use here model for 3d games
       public int health;
       public int damage;
       public float speed;
       public float fireRate;
       public Animator animator;
       
       
       // Add some staff like defense all what you need 
    }
}
