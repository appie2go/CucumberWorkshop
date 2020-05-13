#language: nl

Functionaliteit: Opmaak van een Nederlandse naam

  Scenario: Een simpele naam
    Gegeven een persoon
    En zijn voornaam is "Sander"
    En zijn achternaam is "Verbruggen"
    Als we zijn naam volledig weer willen geven
    Dan staat er "Sander Verbruggen"

  Scenario: Naam van een vrouw
    Gegeven een persoon
    En haar voornaam is "Daphne"
    En haar achternaam is "Verheul"
    Als we haar naam volledig weer willen geven
    Dan staat er "Daphne Verheul"

  Scenario: Een naam met tussenvoegsel
    Gegeven een persoon
    En zijn voornaam is "Victor"
    En zijn tussenvoegsel is "van der"
    En zijn achternaam is "Hulst"
    Als we zijn naam volledig weer willen geven
    Dan staat er "Victor van der Hulst"

  Scenario: Feestje!
    Gegeven een genodigdenlijst met de volgende personen:
      | voornaam | achternaam     |
      | Frank    | Martel         |
      | Michel   | Flens          |
      | Bert     | Grevelink      |
      | Gerard   | Klein Bleumink |
    Als we uitnodigingen gaan versturen
    Dan moeten we 4 uitnodigingen versturen