using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Player _playerPrefab;
        [SerializeField] private PlayerUI _playerUIPrefab;
        [SerializeField] private Transform _uiContainer;
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private int _playersCountOnScene;

        private void OnValidate()
        {
            if (_spawnPoints.Length < _playersCountOnScene) Debug.LogError("Need more spawn points");
        }

        private void Start()
        {
            for (int i = 0; i < _playersCountOnScene; i++)
            {
                var spawnPoint = _spawnPoints[i];

                var _playerGo = Instantiate(_playerPrefab.gameObject, spawnPoint.position, Quaternion.identity);
                var _playerUiGo = Instantiate(_playerUIPrefab.gameObject, _uiContainer);

                var playerComponent = _playerGo.GetComponent<Player>();
                var playerUiComponent = _playerUiGo.GetComponent<PlayerUI>();

                playerUiComponent.Bind(playerComponent);
                playerComponent.Bind(i % 2 == 0 ? (IMoveDirectionSource)new KeyboardDirectionSource() : (IMoveDirectionSource)new MouseDirectionSource());
            }
        }
    }

    public class KeyboardDirectionSource : IMoveDirectionSource
    {
        public Vector3 GetDirection()
        {
            return new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        }
    }

    public class MouseDirectionSource : IMoveDirectionSource
    {
        public Vector3 GetDirection()
        {
            return new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        }
    }
}
