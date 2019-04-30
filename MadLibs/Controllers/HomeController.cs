using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Form() {return View();}

      [Route("/adventure")]
      public ActionResult Adventure (string person1, string person2, string animal, string exclamation, string verb, string noun)
      {
        AdventureVariable myAdventureVariable = new AdventureVariable();
        myAdventureVariable.SetPerson1(person1);
        myAdventureVariable.SetPerson2(person2);
        myAdventureVariable.SetAnimal(animal);
        myAdventureVariable.SetExclamation(exclamation);
        myAdventureVariable.SetVerb(verb);
        myAdventureVariable.SetNoun(noun);
        return View(myAdventureVariable);
      }
  }
}
