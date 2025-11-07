using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        private int id;
        private string u_ime;
        private string u_geslo;
        private static int stIg = 1;
		//privzeti konstruktor
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }
        public Igralec( string u_ime, string u_geslo) {
            this.u_ime = u_ime.Trim();
            this.u_geslo = u_geslo.Trim();
            id = stIg;
            stIg++;
        }
        public Igralec( Igralec igralec) {
            this.u_ime = igralec.u_ime;
            this.u_geslo = igralec.u_geslo;
            this.id = igralec.id;
        }
        public int Id {
            get
            {
                return id;
            }
        }
		//lastnost u_ime
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }
		//geslo
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }
		//breznik bus sendvic
        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
