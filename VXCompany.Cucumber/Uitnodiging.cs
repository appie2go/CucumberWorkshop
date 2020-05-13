namespace VXCompany.Cucumber
{
    public class Uitnodiging
    {
        public Persoon Genodigde { get; set; }

        public Uitnodiging(Persoon genodigde)
        {
            Genodigde = genodigde;
        }
    }
}
