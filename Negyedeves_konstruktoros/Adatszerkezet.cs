namespace Negyedeves_konstruktoros
{
    public class Adatszerkezet
    {
        public Adatszerkezet(string megye, int elson, int masodikn, int harmadikn, int negyedikn)
        {
            this.megye = megye;
            this.elson = elson;
            this.masodikn = masodikn;
            this.harmadikn = harmadikn;
            this.negyedikn = negyedikn;
        }

        public string megye { get; set; }
        public int elson { get; set; }
        public int masodikn { get; set; }
        public int harmadikn { get; set; }
        public int negyedikn { get; set; }
    }
}