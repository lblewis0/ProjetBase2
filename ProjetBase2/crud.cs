using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBase
{
    public struct magasin
    {
        List<produit> listProduit;
        string name;

        //Constructeur structure magasin
        //La structure ne fonctionne pas sans constructeur
        public magasin(string name)
        {
            this.name = name;
            listProduit = new List<produit>();
        }

        public void Ajouter()
        {
            Console.WriteLine("Nom du produit à ajouter:");
            string nomProduit = Console.ReadLine();
            Console.WriteLine("Prix du produit à ajouter:");
            float prixProduit = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantites du produit à ajouter:");
            int quantiteProduit = int.Parse(Console.ReadLine());

            produit nvProd = new produit(nomProduit, prixProduit, quantiteProduit);

            listProduit.Add(nvProd);
            Console.Clear();
        }

        public void Rechercher()
        {
            Console.WriteLine("Nom du produit à rechercher:");
            string nomProd = Console.ReadLine();
            int indexProd = new int();

            StringBuilder sb = new StringBuilder();

            for(int i = 0;i < listProduit.Count;i++)
            {
                string prodName = listProduit[i].Name;
                if (prodName == nomProd)
                {
                    indexProd = i;
                }
                else
                {
                    Console.WriteLine("Le produit n'existe pas");
                }

            }

            sb.AppendLine("------------------------");
            sb.AppendLine($"Produit: {listProduit[indexProd].Name}");
            sb.AppendLine($"Prix: {listProduit[indexProd].Price}");
            sb.AppendLine($"Quantité: {listProduit[indexProd].Quantity}");

            Console.Clear();
            Console.WriteLine(sb);
        }

        public void Modifier(produit prod)
        {

        }

        public void Supprimer(produit prod)
        {

        }

        public void AfficherListeProduits()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();

            if (listProduit != null)
            {
                foreach (produit prod in listProduit)
                {
                    sb.AppendLine("------------------------");
                    sb.AppendLine($"Produit: {prod.Name}");
                    sb.AppendLine($"Prix: {prod.Price}");
                    sb.AppendLine($"Quantité: {prod.Quantity}");
                }

                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("Il n'y a pas de produit en magasin");
            }
            
        }
    }

    public struct produit
    {
        public string Name;
        public float Price;
        public int Quantity;

        /// <summary>
        /// Produit
        /// </summary>
        /// <param name="name">Nom du produit</param>
        /// <param name="price">Prix du produit</param>
        /// <param name="quantity">Quantite du produit</param>
        public produit(string name, float price, int quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }

    public enum actions
    {
        afficherListe, ajouter, rechercher, modifier, supprimer, arret 
    }
}
