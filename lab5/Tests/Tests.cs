using NUnit.Framework;
using System.Collections.Generic;

namespace Testslab5.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();
        private string from1 = string.Empty;
        private string from = string.Empty;
        private string from2 = string.Empty;
        private string to = string.Empty;
        private string to1 = string.Empty;
        private string to2 = string.Empty;
        private string numberOfAdult = string.Empty;
        private string numberOfInfant = string.Empty;
        private string numberOfChildren = string.Empty;
        private string date = "12.01.2018";
        private string returnDate = "17.02.2018";
        private string acc = string.Empty;
        private string acc1 = string.Empty;
        private string date1 = "14.01.2018";
        private string date2 = "15.01.2018";
        private string ticketClass = string.Empty; 

         [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void TestCaseOne()
        {
            from = "Минск, Беларусь";
            to = "Майами, Флорида, США";
            numberOfAdult = "1";
            numberOfInfant = "0";
            numberOfChildren = "0";
            acc = "+/-3 дня";
            ticketClass = "Любой";

            
            steps.SearchCaseModelTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);
        }
        [Test]
        public void TestCaseTwo()
        {
            from = "Минск, Минск-1";
            to = "Нью-Йорк, Нью-Йорк, США";
            numberOfAdult = "1";
            numberOfInfant = "1";
            numberOfChildren = "0";
            acc = "Точная дата";
            ticketClass = "Эконом";
            steps.SearchCaseModelTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);
        }
        [Test]
        public void TestCaseThree()
        {
            from = "Минск-1, Беларусь";
            to = "Сан-Паулу, Бразилия";
            numberOfAdult = "2";
            numberOfInfant = "0";
            numberOfChildren = "0";
            acc = "Точная дата";
            ticketClass = "Эконом";
            steps.SearchCaseModelTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);

          }
        [Test]
        public void TestCaseFour()
        {
            from = "Минск, Минск-1";
            to = "Нью-Йорк, Нью-Йорк, США";
            numberOfAdult = "2";
            numberOfInfant = "2";
            numberOfChildren = "0";
            acc = "Точная дата";
            ticketClass = "Бизнес";
            steps.SearchCaseModelTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);
        }

        [Test]
        public void TestCaseFive()
        {

            from = "Минск-1, Беларусь";
            to = "Минск-1, Беларусь";
            numberOfAdult = "1";
            numberOfInfant = "0";
            numberOfChildren = "0";
            acc = "Точная дата";
            acc1 = "Точная дата";
            ticketClass = "Эконом";
            steps.SearchCaseModelOne(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, date2, acc, acc1, ticketClass);
        }

        [Test]
        public void TestCaseSix()
        {
            from = "Гродно, Беларусь";
            to = "Караганда, Казахстан";
            from1 = "Чуатбалук, Аляска, США";
            to1 = "Нью-Йорк, Нью-Йорк, США";
            numberOfAdult = "1";
            numberOfInfant = "0";
            numberOfChildren = "0";
            acc = "Точная дата";
            acc1 = "Точная дата";
            ticketClass = "Бизнес";
           
            steps.SearchCaseModelThree(from, to, from1, to1, numberOfAdult, numberOfInfant, numberOfChildren, date, date1, ticketClass);
        }

        [Test]
        public void TestCaseSeven()
        {
            from = "Витебск, Беларусь";
            to = "Караганда, Казахстан";
            numberOfAdult = "9";
            numberOfInfant = "0";
            numberOfChildren = "0";
            acc = "Точная дата";
            ticketClass = "Бизнес";
            steps.SearchCaseModelTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);

          }

        [Test]
        public void TestCaseEight()
        {
            from = "Гродно";
            to = "Караганда, Казахстан";
            numberOfAdult = "2";
            numberOfInfant = "1";
            numberOfChildren = "1";
            acc = "Точная дата";
            acc1 = "Точная дата";
            ticketClass = "Бизнес";
            steps.SearchCaseModelOne(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, date2, acc, acc1, ticketClass);
        }

        [Test]
        public void TestCaseNine()
        {
            from = "Гродно, Беларусь";
            to = "Гродно, Беларусь";
            numberOfAdult = "1";
            numberOfInfant = "0";
            numberOfChildren = "0";
            acc = "Точная дата";
            ticketClass = "Бизнес";
            steps.SearchCaseModelTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);

         }

        [Test]
        public void TestCaseTen()
        {
            from = "Минск, Беларусь";
            to = "Майами, Флорида, США";
            numberOfAdult = "3";
            numberOfInfant = "0";
            numberOfChildren = "0";
            acc = "+/-3 дня";
            ticketClass = "Бизнес";
            steps.SearchCaseModelTwo(from, to, numberOfAdult, numberOfInfant, numberOfChildren, date, acc, ticketClass);
            
        }
    }   
}