using System.IO;

namespace vaja6 {

  // Enumerator za tip poklica
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

       private Igralec() { //določi začetne podatke
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id { // vrne id
            get
            {
                return id;
            }
        }

        public string U_ime { // get-set metoda pridobi in nastavi ime
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        public string U_geslo // nastavi geslo
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

        public static int StIg // pridobi število iger
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
