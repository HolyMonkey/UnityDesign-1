using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Good
{
    public class Player : MonoBehaviour
    {
        public UnityEvent OnDeath;

        public event Action<int> MoneyChangeEvent;
        public event Action<int> HealthChangeEvent;

        private int _money;
        private int _health = 2;

        private IMoveDirectionSource _directionSource;

        public void Bind(IMoveDirectionSource directionSource)
        {
            _directionSource = directionSource;
        }

        public void ApplyDamage(int damage)
        {
            if (damage < 0) throw new System.ArgumentOutOfRangeException("damage");

            _health += damage;

            HealthChangeEvent?.Invoke(_health);

            if (_health <= 0)
            {
                Destroy(gameObject);
                OnDeath.Invoke();
            }
        }

        public void AddMoney(int money)
        {
            if (money < 0) throw new System.ArgumentOutOfRangeException("money");

            _money += money;

            MoneyChangeEvent?.Invoke(_money);
        }

        private void Update()
        {
            if (_directionSource == null) return;

            var direction = _directionSource.GetDirection();
            transform.Translate(direction * Time.deltaTime);
        }
    }
}
