using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace VXCompany.Cucumber.Tests
{
    [Binding]
    public class NaamBindings
    {
        private Persoon _persoon;
        private String _volledigeNaam;
        private List<Persoon> _genodigden;
        private List<Uitnodiging> _uitnodigingen;


        [Given("^een persoon$")]
        public void EenPersoon()
        {
            _persoon = new Persoon();
        }

        [Given("^(?:zijn|haar|de) voornaam is \"([^\"]*)\"$")]
        public void ZijnVoornaamIs(string voornaam)
        {
            _persoon.Voornaam = voornaam;
        }

        [Given("^zijn tussenvoegsel is \"([^\"]*)\"$")]
        public void ZijnTussenvoegselIs(string tussenvoegsel)
        {
            _persoon.Tussenvoegsel = tussenvoegsel;
        }

        [Given("^(?:zijn|haar|de) achternaam is \"([^\"]*)\"$")]
        public void ZijnAchternaamIs(String achternaam)
        {
            _persoon.Achternaam = achternaam;
        }

        [When("^we (?:zijn|haar|de) naam volledig weer willen geven$")]
        public void WeZijnNaamVolledigWeerWillenGeven()
        {
            _volledigeNaam = _persoon.VolledigeNaam;
        }

        [Then("^staat er \"([^\"]*)\"$")]
        public void StaatEr(String verwachteNaam)
        {
            verwachteNaam.Should().Be(_volledigeNaam);
        }

        [Given("^een genodigdenlijst met de volgende personen:$")]
        public void EenGenodigdenlijstMetDeVolgendePersonen(Table table)
        {
            _genodigden = table.Rows
                .Select(x => new Persoon
                {
                    Voornaam = x[0],
                    Achternaam = x[1]
                })
                .ToList();
        }

        [When("^we uitnodigingen gaan versturen$")]
        public void WeUitnodigingenGaanVersturen()
        {
            this._uitnodigingen = this._genodigden
                .Select(x => new Uitnodiging(x))
                .ToList();
        }

        [Then("^moeten we (\\d+) uitnodigingen versturen$")]
        public void WoetenWeUitnodigingenVersturen(int verwachtAantal)
        {
            _uitnodigingen.Count().Should().Be(verwachtAantal);
        }
    }
}
