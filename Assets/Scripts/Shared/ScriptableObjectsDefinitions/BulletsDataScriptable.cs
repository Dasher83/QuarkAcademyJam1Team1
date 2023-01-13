using UnityEngine;

namespace LimboOfCeres.Scripts.Shared.ScriptableObjectsDefinitions
{
    [CreateAssetMenu(fileName = "BulletsDataScriptable", menuName = "ScriptableObjects/BulletsDataScriptable", order = 5)]
    public class BulletsDataScriptable : ScriptableObject
    {
        [SerializeField] private float curvedProbability;
        [SerializeField] private float bounciness;
        [SerializeField] private float gravityScaleMinimum;
        [SerializeField] private float gravityScaleMaximum;

        public void Initialize()
        {
            this.curvedProbability = Constants.Projectiles.Bullet.CurvedProbability.Minimum;
            this.bounciness = Constants.Projectiles.Bullet.Bounciness.Minimum;
            this.gravityScaleMinimum = Constants.Projectiles.Bullet.GravityScaleMinimum.Minimum;
            this.gravityScaleMaximum = Constants.Projectiles.Bullet.GravityScaleMaximum.Minimum;
        }

        public float CurvedProbability
        {
            get { return curvedProbability; }

            set
            {
                if (value > Constants.Projectiles.Bullet.CurvedProbability.Maximum)
                {
                    curvedProbability = Constants.Projectiles.Bullet.CurvedProbability.Maximum;
                    return;
                }

                if(value < Constants.Projectiles.Bullet.CurvedProbability.Minimum)
                {
                    curvedProbability = Constants.Projectiles.Bullet.CurvedProbability.Minimum;
                    return;
                }

                curvedProbability = value;
            }
        }

        public float Bounciness
        {
            get { return bounciness; }

            set
            {
                if (value > Constants.Projectiles.Bullet.Bounciness.Maximum)
                {
                    bounciness = Constants.Projectiles.Bullet.Bounciness.Maximum;
                    return;
                }

                if (value < Constants.Projectiles.Bullet.Bounciness.Minimum)
                {
                    bounciness = Constants.Projectiles.Bullet.Bounciness.Minimum;
                    return;
                }

                bounciness = value;
            }
        }

        public float GravityScaleMinimum { get { return gravityScaleMinimum; } set { gravityScaleMinimum = value; } }

        public float GravityScaleMaximum { get { return gravityScaleMaximum; } set { gravityScaleMaximum = value; } }
    }
}
