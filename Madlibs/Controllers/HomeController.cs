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
}