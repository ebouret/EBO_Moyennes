using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    class Classe
    {
        public string nomClasse
        { get; private set; }

        public string[] matieres
        { get; private set; }

        public Eleve[] eleves
        { get; private set; }

        //indices des eleves et matieres
        private int i = 0;
        public int j = 0;

        //Constructeur
        public Classe(string c)
        {
            nomClasse = c;
            matieres = new string[10];
            eleves = new Eleve[30];
        }

        //Méthodes
        public void ajouterEleve(string prenom, string nom)
        {
            eleves[i] = new Eleve(prenom, nom);
            i++;
        }

        public void ajouterMatiere(string matiere)
        {
            matieres[j] = matiere;
            j++;
        }
        
        public decimal moyenneGeneral()
        {
            decimal totalG = 0;
            int nbrMoyM = 0;

            for (int l = 0; l < j; l++)
            {
                totalG = totalG + moyenneMatiere(l);
                nbrMoyM++;
            }

            return Math.Round(totalG / nbrMoyM, 2);
        }

        public decimal moyenneMatiere(int m)
        {
            decimal totalM = 0;
            int nbrMoy = 0;

            for (int l = 0; l<i; l++)
            {
                totalM = totalM + eleves[l].moyenneMatiere(m);
                nbrMoy++;
            }

            return Math.Round(totalM / nbrMoy, 2);
        }

    }
}
