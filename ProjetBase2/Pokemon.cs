using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBase
{
    public struct Pokemon
    {
        public string Name;
        public int Level;
        public int PV;
        public int Atk;
        public int AtkSpe;
        public int Def;
        public int DefSpe;
        public int Vitesse;

        /// <summary>
        /// Cree un nouveau pokeman level 1 avec stats aléatoires
        /// </summary>
        /// <param name="name">Nom du pokemon</param>
        public Pokemon(string name)
        {
            Random rng = new Random();
            Name = name;
            Level = 1;
            PV = rng.Next(15, 21);
            Atk = rng.Next(5, 11);
            AtkSpe = rng.Next(5, 11);
            Def = rng.Next(5, 11);
            DefSpe = rng.Next(5, 11);
            Vitesse = rng.Next(5, 11);
        }

        /// <summary>
        /// Cree un nouveau pokemon avec stats choisies
        /// </summary>
        /// <param name="name">Nom du pokemon</param>
        /// <param name="level">Niveau du pokemon</param>
        /// <param name="pV">Points de vie du pokemon</param>
        /// <param name="atk">Attaque du pokemon</param>
        /// <param name="atkSpe">Attaque speciale du pokemon</param>
        /// <param name="def">Defense du pokemon</param>
        /// <param name="defSpe">Defense speciale du pokmon</param>
        /// <param name="vitesse">Vitesse du pokemon</param>
        public Pokemon(string name, int level, int pV, int atk, int atkSpe, int def, int defSpe, int vitesse)
        {
            Name = name;
            Level = level;
            PV = pV;
            Atk = atk;
            AtkSpe = atkSpe;
            Def = def;
            DefSpe = defSpe;
            Vitesse = vitesse;
        }
        public void TakeDamage(int damage)
        {
            Console.WriteLine($"{this.Name} reçoit {damage} points de dégats");
            this.PV = PV - damage < 0 ? 0 : PV - damage;
            //Condition ternaire en haut
            //if (PV - damage < 0)
            //{
            //    this.PV = 0;
            //}
            //else
            //{
            //    this.PV = PV - damage;
            //}
        }

        /// <summary>
        /// Notre pokemon attaque une target
        /// </summary>
        /// <param name="target">La cible de l'attaque</param>
        public void Attack(ref Pokemon target)
        {
            Console.WriteLine($"{this.Name} attaque {target.Name}");
            target.TakeDamage(this.Atk);
        }

        public override string ToString()
        {
            return $"-----------------------\n" +
                   $"Name: {Name}\n" +
                   $"Level: {Level}\n" +
                   $"PV: {PV}\n" +
                   $"Atk: {Atk}\n" +
                   $"AtkSpe: {AtkSpe}\n" +
                   $"Def: {Def}\n" +
                   $"DefSpe: {DefSpe}\n" +
                   $"Vitesse: {Vitesse}\n" +
                   $"-----------------------";
        }

    }
}
