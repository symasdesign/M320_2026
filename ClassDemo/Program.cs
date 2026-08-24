namespace ClassDemo {
    internal class Program {
        static void Main(string[] args) {

            Rechteck r1 = new Rechteck();
            r1.Hoehe = 1;
            r1.Breite = 2;
            r1.Position = new Punkt() { X = 3, Y = 3 };
            r1.LinienFarbe = "grün";
            //r1.flaeche = 7;

            //r1.Zeichne();
            //r1.Skaliere(0.5);
            //r1.Zeichne();
            //r1.Verschiebe(2,3);
            //r1.Skaliere(0.5);
            //r1.Zeichne();

            Rechteck r2 = new Rechteck();
            r2.Hoehe = 9;
            r2.Breite = 8;
            r2.LinienFarbe = "blau";
            r2.Position = new Punkt() { Y = 4, X = 5 };
            //Rechteck.Winkelsumme = 400;
            r2.Zeichne();
            r1.Zeichne();
        }
    }

    public class Rechteck {

        //public int Id;  // Klassenvariable oder Attribut
        public readonly int Id;  // readonly Klassenvariable oder Attribut 
        public double Hoehe { get; set; }   // Property
        //public double Breite { get; }   // ReadOnly-Property
        public double Breite { get; set;  }   // ReadOnly-Property

        public double Umfang {
            get { 
                //return Hoehe + Breite + Hoehe + Breite;
                return 2 * Hoehe + 2 * Breite;
            }
        }

        public Punkt Position { get; set; }

        public string LinienFarbe { get; set; }

        public static int Winkelsumme { get;  } = 360;

        private double flaeche;

        public void Verschiebe(double dx, double dy) {
            double newX = Position.X + dx;
            double newY = Position.Y + dy;

            Position = new Punkt() { X = newX, Y = newY };
        }

        public void Skaliere(double faktor) {
            Breite = Breite * faktor;
            Hoehe = Hoehe * faktor;
        }

        public void Zeichne() {
            Console.WriteLine($"Rechteck Id={Id}, Hoehe={Hoehe}, Breite={Breite}, Winkelsumme={Winkelsumme}, Umfange={Umfang}, Position.X={Position.X}, Position.Y={Position.Y}, LinienFarbe={LinienFarbe}");
        }
    }

    public class Punkt {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
