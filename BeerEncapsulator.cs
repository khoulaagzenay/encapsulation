using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace encapsulation
{
    public class BeerEncapsulator
    {
        //Attributs
        private decimal _avalaibleBeerVolume;
        private int _avalaibleBottles;
        private int _avalaibleCapsules;


        //Constructeurs
        public BeerEncapsulator(decimal stockInitialBeer, int bottelsDispo, int capsulesDispo)
        {
            _avalaibleBeerVolume = stockInitialBeer;
            _avalaibleBottles = bottelsDispo;
            _avalaibleCapsules = capsulesDispo;
        }

        //public decimal AvailableBeerVolume => _avalaibleBeerVolume;

        public decimal AvalaibleBeerVolume
        {
            get { return _avalaibleBeerVolume; }
            set { _avalaibleBeerVolume = value; }
        }
        public int AvalaibleBottles
        {
            get { return _avalaibleBottles; }
            set { _avalaibleBottles = value; }
        }
        public int AvalaibleCapsules
        {
            get { return _avalaibleCapsules; }
            set { _avalaibleCapsules = value; }
        }

        //Methode pour verifier si le stock est suffisant :
        public bool IsStockOK()
        {
            if (_avalaibleBeerVolume < 33 || _avalaibleBottles < 0 || _avalaibleCapsules < 0)
            {
                Console.WriteLine("Composants insuffisants pour commencer");
                return false;
            }

            Console.WriteLine("Ready to Go");
            return true;

        }

        //methode AddBeer
        //Ajoute la bière dans une bouteille
        public decimal AddBeer(decimal VolumeBeer)
        {
            _avalaibleBeerVolume -= 33;
            return _avalaibleBeerVolume;
        }

        public int ProduceEncapsulatedBeerBottles(int BottleAFabriquer)
        {
            int BottleFabriques = 0;

            while (BottleFabriques != BottleAFabriquer)
            {
                if (_avalaibleBeerVolume >= 33 && _avalaibleCapsules > 0 && _avalaibleBottles > 0)
                {
                    _avalaibleCapsules = _avalaibleCapsules - 1;
                    _avalaibleBeerVolume = _avalaibleBeerVolume - 33;
                    _avalaibleBottles = _avalaibleBottles - 1;
                    BottleFabriques++;

                }
                else
                {
                    Console.WriteLine("Composant insuffisant");
                    if (_avalaibleBeerVolume < 33)
                        Console.WriteLine("La quantité de la volume est inférieur à la quantité min " + ". Il vous reste une quantité de :" + ((BottleAFabriquer - BottleFabriques) * 33));

                    else if (_avalaibleCapsules == 0)
                        Console.WriteLine("La quantité de capsule est inférieur à la quantité min  " + (BottleAFabriquer - BottleFabriques));

                    else if (_avalaibleBottles == 0)
                        Console.WriteLine("La quantité de capsule est inférieur à la quantité min  " + (BottleAFabriquer - BottleFabriques));

                    Console.WriteLine($"Bouteilles fabriqués : {BottleFabriques}");
                    return BottleFabriques;
                }
            }
            return BottleFabriques;
 
        }
        public void display()
        {
            Console.WriteLine($"Bière disponible : {AvalaibleBeerVolume} centilitres");
            Console.WriteLine($"Bouteilles disponibles : {AvalaibleBottles}");
            Console.WriteLine($"Capsules disponibles : {AvalaibleCapsules}");
            Console.WriteLine();
        }
    }

}