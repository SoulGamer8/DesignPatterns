using System;


namespace Nevermindever.AbstractFactory.Enemy.Logic {
    public class Health {
        public int CurrentHealth{get;private set;}
        public int MaxHealth {get;private set;}
        public Action OnDeath;

        public Health(int maxHealth){
            CurrentHealth = maxHealth;
            MaxHealth = maxHealth;
        }

        
        public void TakeDamage(int damage) {
            CurrentHealth -= damage;
            if (CurrentHealth <= 0) 
                OnDeath?.Invoke();
        }

        public void Heal(int heal) {
            CurrentHealth += heal;
            if(CurrentHealth > MaxHealth)
                CurrentHealth = MaxHealth;
        }
    }
}
