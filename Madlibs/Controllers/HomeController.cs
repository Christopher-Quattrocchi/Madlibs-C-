using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers;

public class HomeController : Controller
{
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/mad-libs")]
    public ActionResult Form() { return View(); }

    [Route("/mad-libs-two")]
    public ActionResult FormTwo() { return View(); }

    [Route("/madlib")]
    public ActionResult Madlib(string emotionOne, string adjectiveOne, string placeOne, string thingOne, string thingTwo, string placeTwo, string foodOne, string thingThree, string thingFour, string treatOne, string placeThree, string adjectiveTwo)
    {
        MadlibsVariables myMadlibsVariables = new MadlibsVariables();
         myMadlibsVariables.EmotionOne = emotionOne;
         myMadlibsVariables.AdjectiveOne = adjectiveOne;
         myMadlibsVariables.PlaceOne = placeOne;
         myMadlibsVariables.ThingOne = thingOne;
         myMadlibsVariables.ThingTwo = thingTwo;
         myMadlibsVariables.PlaceTwo = placeTwo;
         myMadlibsVariables.FoodOne = foodOne;
         myMadlibsVariables.ThingThree = thingThree;
         myMadlibsVariables.ThingFour = thingFour;
         myMadlibsVariables.TreatOne = treatOne;
         myMadlibsVariables.PlaceThree = placeThree;
         myMadlibsVariables.AdjectiveTwo = adjectiveTwo;

        return View(myMadlibsVariables);
    }

    [Route("/madlib-two")]
    public ActionResult MadlibTwo(string adjectiveOne, string nounOne, string verbOne, string adverbOne, string adjectiveTwo, string nounTwo, string nounThree, string adjectiveThree, string verbTwo, string adverbTwo, string verbThree, string adjectiveFour)
    {
        MadlibsVariablesTwo myMadlibsVariablesTwo = new MadlibsVariablesTwo();
        myMadlibsVariablesTwo.AdjectiveOne = adjectiveOne;
        myMadlibsVariablesTwo.NounOne = nounOne;
        myMadlibsVariablesTwo.VerbOne = verbOne;
        myMadlibsVariablesTwo.AdverbOne = adverbOne;
        myMadlibsVariablesTwo.AdjectiveTwo = adjectiveTwo;
        myMadlibsVariablesTwo.NounTwo = nounTwo;
        myMadlibsVariablesTwo.NounThree = nounThree;
        myMadlibsVariablesTwo.AdjectiveThree = adjectiveThree;
        myMadlibsVariablesTwo.VerbTwo = verbTwo;
        myMadlibsVariablesTwo.AdverbTwo = adverbTwo;
        myMadlibsVariablesTwo.VerbThree = verbThree;
        myMadlibsVariablesTwo.AdjectiveFour = adjectiveFour;

        return View(myMadlibsVariablesTwo);
    }
}