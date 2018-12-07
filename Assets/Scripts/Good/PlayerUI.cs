using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Good
{
    public class PlayerUI : MonoBehaviour
    {
        [SerializeField] private Text _healthText;
        [SerializeField] private Text _moneyText;

        private Player _player;

        public void Bind(Player player)
        {
            _player = player;
            enabled = true;
        }

        private void Awake()
        {
            if (_player == null) enabled = false;
        }

        private void OnEnable()
        {
            if (_player == null) return;

            _player.HealthChangeEvent += SetHealth;
            _player.MoneyChangeEvent += SetMoney;
        }

        private void OnDisable()
        {
            if (_player == null) return;

            _player.HealthChangeEvent -= SetHealth;
            _player.MoneyChangeEvent -= SetMoney;
        }

        private void SetHealth(int health)
        {
            _healthText.text = health.ToString();
        }

        private void SetMoney(int money)
        {
            _moneyText.text = money.ToString();
        }
    }
}
