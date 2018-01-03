using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Testslab5.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.Driver.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.Driver.CloseBrowser();
        }

        
        public void SearchCaseModelOne(string from, string to, string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string returnDate, string acc, string acc1, string ticketClass)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.SearchOne(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, returnDate, acc, acc1, ticketClass);

        }

        public void SearchCaseModelTwo(string from, string to, string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string acc, string ticketClass)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.SearchTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);
            ;
        }

        public void SearchCaseModelThree(string from, string to, string from1, string to1, string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string date1, string ticketClass)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.SearchThree(from, to, from1, to1, numberOfAdult, numberOfInfant, numberOfChildren, date, date1, ticketClass);
        }

        public void SearchCaseModelFour(string from, string to, string from1, string to1, string from2, string to2,  string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string date1, string date2, string ticketClass)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.SearchFour(from, to, from1, to1, from2, to2, numberOfAdult, numberOfInfant, numberOfChildren, date, date1, date2, ticketClass);
        }
    }
}
