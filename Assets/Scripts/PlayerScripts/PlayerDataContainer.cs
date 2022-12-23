using LimboOfCeres.Scripts.Shared.ScriptableObjectsDefinitions;
using UnityEngine;

namespace LimboOfCeres.Scripts.PlayerScritps
{
    public class PlayerDataContainer : MonoBehaviour
    {
        [SerializeField]
        private PlayerData playerData;

        public PlayerData PlayerData { get { return playerData; } }
    }
}
