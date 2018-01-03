using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace Testslab5.Pages
{
    class FlightsPage
    {
        private const string BASE_URL = "https://avia.tickets.ua/";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "from_name")]
        private IWebElement From;

        [FindsBy(How = How.Id, Using = "to_name")]
        private IWebElement To;

        [FindsBy(How = How.Id, Using = "departure_date")]
        private IWebElement Depart;

        [FindsBy(How = How.Id, Using = "from_name1")]
        private IWebElement From1;

        [FindsBy(How = How.Id, Using = "to_name1")]
        private IWebElement To1;

        [FindsBy(How = How.Id, Using = "departure_date1")]
        private IWebElement Depart1;

        [FindsBy(How = How.Id, Using = "from_name2")]
        private IWebElement From2;

        [FindsBy(How = How.Id, Using = "to_name2")]
        private IWebElement To2;

        [FindsBy(How = How.Id, Using = "departure_date2")]
        private IWebElement Depart2;

        [FindsBy(How = How.Id, Using = "plus-minus-chosen")]
        private IWebElement AccuracyTime;

        [FindsBy(How = How.Id, Using = "departure_date_1")]
        private IWebElement ReturnDate;

        [FindsBy(How = How.Id, Using = "plus_minus_chosen_1")]
        private IWebElement AccuracyTime1;

        [FindsBy(How = How.Name, Using = "adt")]
        private IWebElement Adult;
        [FindsBy(How = How.Name, Using = "chd")]
        private IWebElement Children;
        [FindsBy(How = How.Name, Using = "inf")]
        private IWebElement Infant;

        [FindsBy(How = How.Id, Using = "Class_Select_chosen")]
        private IWebElement Service;


        [FindsBy(How = How.Id, Using = "OneWay")]
        private IWebElement OneWay;
        [FindsBy(How = How.Id, Using = "round_trip")]
        private IWebElement TwoWay;
        [FindsBy(How = How.Id, Using = "complex_flight")]
        private IWebElement Complex;


        [FindsBy(How = How.ClassName, Using = "search_button")]
        private IWebElement SearchBtn;

        [FindsBy(How = How.ClassName, Using = "add_flight")]
        private IWebElement AddBtn;

        public FlightsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void SearchOne(string from, string to, string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string returnDate, string acc, string acc1, string ticketClass)
        {
            ClearValue();
            TwoWay.Click();
            From.SendKeys(from);
            To.SendKeys(to);
            Depart.SendKeys(date);
            ReturnDate.SendKeys(returnDate);
            AccuracyTime.SendKeys(acc);
            AccuracyTime1.SendKeys(acc1);
            Adult.SendKeys(numberOfAdult);
            Infant.SendKeys(numberOfInfant);
            Children.SendKeys(numberOfChildren);
            Service.SendKeys(ticketClass);
            SearchBtn.Click();
        }
        
        public void SearchTwo(string from, string to, string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string acc, string ticketClass)
        {
            ClearValue();
            OneWay.Click();
            From.SendKeys(from);
            To.SendKeys(to);
            Depart.SendKeys(date);
            AccuracyTime.SendKeys(acc);
            Adult.SendKeys(numberOfAdult);
            Infant.SendKeys(numberOfInfant);
            Children.SendKeys(numberOfChildren);
            Service.SendKeys(ticketClass);
            SearchBtn.Click();
        }

        public void SearchThree(string from, string to, string from1, string to1, string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string date1, string ticketClass)
        {
            ClearValue();
            Complex.Click();
            From.SendKeys(from);
            To.SendKeys(to);
            From1.SendKeys(from1);
            To1.SendKeys(to1);
            Depart.SendKeys(date);
            Depart1.SendKeys(date1);
            Adult.SendKeys(numberOfAdult);
            Infant.SendKeys(numberOfInfant);
            Children.SendKeys(numberOfChildren);
            Service.SendKeys(ticketClass);
            SearchBtn.Click();
        }

        public void SearchFour(string from, string to, string from1, string to1, string from2, string to2, string numberOfAdult, string numberOfInfant, string numberOfChildren, string date, string date1, string date2, string ticketClass)
        {
            ClearValue();
            Complex.Click();
            AddBtn.Click();
            From.SendKeys(from);
            To.SendKeys(to);
            From1.SendKeys(from1);
            To1.SendKeys(to1);
            From2.SendKeys(from2);
            To2.SendKeys(to2);
            Depart.SendKeys(date);
            Depart1.SendKeys(date1);
            Depart2.SendKeys(date2);
            Adult.SendKeys(numberOfAdult);
            Infant.SendKeys(numberOfInfant);
            Children.SendKeys(numberOfChildren);
            Service.SendKeys(ticketClass);
            SearchBtn.Click();
        }

        public void ClearValue()
        {
            From.Clear();
            Depart.Clear();
            From1.Clear();
            Depart1.Clear();
            From2.Clear();
            Depart2.Clear();
        }
    }
}
