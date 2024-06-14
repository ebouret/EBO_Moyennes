using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    class Eleve
    {
        public string prenom
        { get; private set; }
        public string nom
        { get; private set; }
        public Note[] note
        { get; private set; }
        
        //Compteur de notes
        private int k;

        //constructeur
        public Eleve(string p, string n)
        {
            prenom = p;
            nom = n;
            note = new Note[200];

        }

        public decimal moyenneGeneral()
        {
            decimal totalG = 0;
            int nbrMoy = 0;            

            for (int l = 0; l < 10;  l++)
            {
                if (moyenneMatiere(l) == 0)
                {
                    break;
                }
                else
                {
                    totalG = totalG + moyenneMatiere(l);
                    nbrMoy = nbrMoy + 1;
                }
                
            }

            return Math.Round(totalG / nbrMoy, 2);
        }

        public decimal moyenneMatiere(int m)
        {
            float totalM = 0;
            int nbrNotes = 0;

            for (int l= 0; l < k; l++)
            {
                
                if (note[l].matiere == m)
                {
                    totalM = totalM + note[l].note;
                    nbrNotes = nbrNotes + 1;
                }
            }

            //Test : si la matiere n'a aucune note, retourne 0
            if (nbrNotes == 0)
            {
                return 0;
            }
            else
            {
                return Math.Round((decimal)totalM / nbrNotes, 2);
            }
                
        }

        public void ajouterNote(Note n)
        {
            note[k] = n;
            k++;
        }
    }
}
