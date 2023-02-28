using LimboOfCeres.Scripts.Shared;
using LimboOfCeres.Scripts.Shared.Interfaces;
using LimboOfCeres.Scripts.Utils;
using UnityEngine;


namespace LimboOfCeres
{
    [CreateAssetMenu(fileName = "ExtraLifeData", menuName = "ScriptableObjects/ExtraLifeData", order = 6)]
    public class ExtraLifeScriptable : ScriptableObject, IInitializable
    {
        public LimitedNumericProperty<float> SpawnRateMinimum;
        public LimitedNumericProperty<float> SpawnRateMaximum;
        public LimitedNumericProperty<float> MovementSpeed;

        public void Initialize()
        {
            SpawnRateMinimum = new LimitedNumericProperty<float>(
                initialValue: Constants.ExtraLife.SpawnRateMinimum.Maximum,
                minimum: Constants.ExtraLife.SpawnRateMinimum.Minimum,
                maximum: Constants.ExtraLife.SpawnRateMinimum.Maximum);
        }

        public float SpawnRate => Random.Range(SpawnRateMinimum.LimitedValue, Constants.ExtraLife.MaximumRespawnTime);
    }
}
