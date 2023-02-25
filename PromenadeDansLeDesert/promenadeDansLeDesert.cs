using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromenadeDansLeDesert
{
    class promenadeDansLeDesert
    {
        public delegate void Direction();

        private Direction ToutDroit;
        private Direction RetourEnArriere;
        private List<Direction> Parcours = new List<Direction>();

        private void Nord() {
            Console.WriteLine("Vous allez vers le Nord");
        }
        private void Sud() {
            Console.WriteLine("Vous allez vers le Sud");
        }
        private void Est()
        {
            Console.WriteLine("Vous allez vers l'Est");
        }
        private void Ouest()
        {
            Console.WriteLine("Vous allez vers l'Ouest");
        }
        private void CaseDepart()
        {
            Parcours.Reverse();
            foreach (Direction parcours in Parcours)
            {
                parcours();
            }
            Parcours.Clear();
        }

        public promenadeDansLeDesert() {
            ToutDroit = Nord;
            RetourEnArriere = Sud;
        }
        public void Avancer()
        {
            string choix;
            do
            {
                Console.WriteLine("Dans quelle direction souhaitez-vous aller ?");
                Console.WriteLine("N[ord] S[ud] O[est] E[st] T[out droit] R[etour] F[in] C[ase Depart]");
                Console.Write(Parcours.Count);
                
                choix = Console.ReadLine();
                if (choix == "N")
                {
                    Nord();
                    RetourEnArriere = Sud;
                    ToutDroit = Nord;
                    Parcours.Add(RetourEnArriere);
                }
                else if (choix == "S")
                {
                    Sud();
                    RetourEnArriere = Nord;
                    ToutDroit = Sud;
                    Parcours.Add(RetourEnArriere);
                }
                else if (choix == "O")
                {
                    Ouest();
                    RetourEnArriere = Est;
                    ToutDroit = Ouest;
                    Parcours.Add(RetourEnArriere);
                }
                else if (choix == "E")
                {
                    Est();
                    RetourEnArriere = Ouest;
                    ToutDroit = Est;
                    Parcours.Add(RetourEnArriere);
                }
                else if (choix == "T")
                {
                    ToutDroit();
                    Parcours.Add(RetourEnArriere);
                }
                else if (choix == "R")
                {
                    RetourEnArriere();
                    Parcours.RemoveAt(Parcours.Count - 1);
                }
                else if (choix == "F")
                {
                    Console.WriteLine("*** Fin de la Promenade ***");
                }
                else if(choix == "C")
                {
                    CaseDepart();
                }
                else
                {
                    Console.WriteLine("Dans quelle direction souhaitez-vous aller ?");
                    Console.WriteLine("N[ord] S[ud] O[est] E[st] T[out droit] R[etour] F[in]");
                }
            }
            while (choix != "F");
            Console.ReadLine();
        }
    }
}
