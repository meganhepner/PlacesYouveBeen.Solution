using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {

    // public void Dispose()
    // {
    //   // Method to delete all instances of Place in _allPlaces
    // }
    
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place();
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void PlaceConstructor_CityNameParamater_Added()
    {
      Place newPlace = new Place("Hong Kong");
      Assert.AreEqual("Hong Kong", newPlace.CityName);
    }

    [TestMethod]
    public void DeleteAll_EmptyTheListOfPlaces_EmptyList()
    {
      Place newPlace = new Place("Timbuktu");
      Place.DeleteAll();
      List<Place> _expectedResults = new List<Place>(0);
      CollectionAssert.AreEqual(_expectedResults, Place.GetAll());
    }

    [TestMethod]
    public void GetAll_ShowsListOfAllPlaceObjects_ListMatches()
    {
      Place newPlace1 = new Place("Hong Kong");
      Place newPlace2 = new Place("Ulan Baatar");
      Place newPlace3 = new Place("St Petersburg");
      List<Place> _expectedResults = new List<Place> {newPlace1, newPlace2, newPlace3};
      CollectionAssert.AreEqual(_expectedResults, Place.GetAll());
    }
  }
}