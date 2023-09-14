using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalno_ponavljanje_1
{
    internal class Program
    {
        class Vozilo
        {
            private bool jeLiPlovi;
            private bool jeLiLeti;

            public Vozilo()
            {

            }
            public Vozilo(bool jeLiPlovi, bool jeLiLeti)
            {
                this.jeLiPlovi = jeLiPlovi;
                this.jeLiLeti = jeLiLeti;
            }

            public bool JeLiLeti { get => jeLiLeti; set => jeLiLeti = value; }
            public bool JeLiPlovi { get => jeLiPlovi; set => jeLiPlovi = value; }

            public string KudaVozi()
            {
                return "Vozilo leti: " + this.JeLiLeti + " Vozilo plovi: " + this.JeLiPlovi;
            }
        }
        class Brod : Vozilo
        {
            public Brod() 
            {

            }

            public Brod(bool JeLiPlovi, bool JeLiLeti) : base(JeLiLeti, JeLiPlovi)
            {
                
            }
            public string KudaVozi()
            {
                this.JeLiLeti = false;
                this.JeLiPlovi = true;
                return base.KudaVozi();
            }

        }
        class Zrakoplov : Vozilo
        {
            public Zrakoplov()
            {

            }
            Zrakoplov(bool JeLiPlovi, bool JeLiLeti) : base(JeLiLeti, JeLiPlovi)
            {
                
            }
            public string KudaVozi()
            {
                this.JeLiLeti = true;
                this.JeLiPlovi = false;
                return base.KudaVozi();
            }

        }
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov zrakoplov = new Zrakoplov();

            Console.WriteLine("Brod:");
            Console.WriteLine(brod.KudaVozi());
            Console.WriteLine("Zrakoplov:");
            Console.WriteLine(zrakoplov.KudaVozi());

            Console.ReadKey();
        }
    }
}
