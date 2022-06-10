namespace Nevek_beolvasasa_2keresztnev
{
    public class Adatszerkezet
    {
        public Adatszerkezet(string vnev, string knev1, string knev2)
        {
            this.vnev = vnev;
            this.knev1 = knev1;
            this.knev2 = knev2;
        }

        public string vnev { get; set; }
        public string knev1 { get; set; }
        public string knev2 { get; set; }
    }
}