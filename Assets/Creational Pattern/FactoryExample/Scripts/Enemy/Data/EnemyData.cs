using UnityEngine;

namespace Nevermindever.Factory.Enemy.Data{
    public class EnemyData : ScriptableObject{
       public string name;
       public Color color; // we can use here model for 3d games or sprite for 2D  games
       public int health;
       public int damage;
       public float speed;
       public float fireRate;
       public float fireRange;
       public float escapeRange; 
       public Animator animator;
       
       
       // Add some staff like defense all what you need 
    }
}
