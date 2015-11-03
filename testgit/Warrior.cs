using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testgit
{
    class Warrior
    {

        public Warrior(string Name)
        {
            this.Name = Name;
        }


        private readonly string Name;

        #region Показатели чампа

        /// <summary>
        /// Показатель максимального запаса здоровья
        /// </summary>
        public int MaxHealth { get; set; }
        /// <summary>
        /// Текущий показатель здоровья
        /// </summary>
        public int CurHealth { get; set; }

        /* Показатели урона */


        public int MaxAD { get; set; }
        public int CurAD { get; set; }
        public int MaxAP { get; set; }
        public int CurAP { get; set; }

        /* Показатели защиты */
        public int MaxArmor { get; set; }
        public int CurArmor { get; set; }
        public int MaxMagicResist { get; set; }
        public int CurMagicResist { get; set; }

        /* Показатели скорости передвижения */
        public int MaxSpeed { get; set; }
        public int CurSpeed { get; set; }
        public double MaxAttackSpeed { get; set; }
        public double CurAttackSpeed { get; set; }

        #endregion

        #region Атака
        public void SetAutoAttack(Warrior Enemy, int CurAD)
        {

        }
        public void GetAutoAttack()
        {

        }
        #endregion
    }
}