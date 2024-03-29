﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaygroundLibary.Config;
using PlaygroundLibary.Pages;
using PlaygroundLibrary.Pages;

namespace PlaygroundTests
{
    [TestClass]
    public class PlaygroundTest : TestBase
    {
        [TestMethod]
        public void Test_1_1_CreateSeniority()
        {
            Assert.IsTrue(LoginPage.IsAt(), "Login page is not opened!");
            LoginPage.Login();
            Assert.IsTrue(DashboardPage.IsAt(), "Dashboard page is not opened after login action!");
            DashboardPage.OpenPlayground();
            Assert.IsTrue(PlaygroundPage.IsAt(), "Dashboard page is not opened after login action!");
            PlaygroundPage.OpenTab("Seniorities");
            Assert.IsTrue(PlaygroundPage.IsSeniorityTabOpened(), "Seniority tab is not open!");
            PlaygroundPage.CreateSeniority("Junior");
            Assert.IsTrue(PlaygroundPage.IsCreatedSeniorityInList(), "Created Seniority is not in the list of all Seniorityies!");
        }

        [TestMethod]
        public void Test_1_2_CreateTechnology()
        {
            Assert.IsTrue(LoginPage.IsAt(), "Login page is not opened!");
            LoginPage.Login();
            Assert.IsTrue(DashboardPage.IsAt(), "Dashboard page is not opened after login action!");
            DashboardPage.OpenPlayground();
            Assert.IsTrue(PlaygroundPage.IsAt(), "Dashboard page is not opened after login action!");
            PlaygroundPage.OpenTab("Technologies");
            Assert.IsTrue(PlaygroundPage.IsTechnologyTabOpened(), "Technology tab is not open!");
            PlaygroundPage.CreateTechnology("Java");
            Assert.IsTrue(PlaygroundPage.IsCreatedTechnologyInList(), "");
        }

        [TestMethod]
        public void Test_1_3_CreatePerson()
        {
            Assert.IsTrue(LoginPage.IsAt(), "Login page is not opened!");
            LoginPage.Login();
            Assert.IsTrue(DashboardPage.IsAt(), "Dashboard page is not opened after login action!");
            DashboardPage.OpenPlayground();
            Assert.IsTrue(PlaygroundPage.IsAt(), "Dashboard page is not opened after login action!");
            PlaygroundPage.OpenPeopleTab();
            Assert.IsTrue(PlaygroundPage.IsPeopleTabOpened(), "People tab is not opened!");
            PlaygroundPage.CreatePerson();
            Assert.IsTrue(PlaygroundPage.IsCreateFormOpened(), "");
            PlaygroundPage.EnterFullName("Dragana Draganic");
            PlaygroundPage.ChooseSeniorities("Junior");
            PlaygroundPage.ChooseTehnologies("Java");
            PlaygroundPage.SavePerson();
            Assert.IsTrue(PlaygroundPage.IsCreatedPersonInList(), "Created person is not in the list!");
        }

        [TestMethod]
        public void Test_1_4_SwitchPersonName()
        {
            Assert.IsTrue(LoginPage.IsAt(), "Login page is not opened!");
            LoginPage.Login();
            Assert.IsTrue(DashboardPage.IsAt(), "Dashboard page is not opened after login action!");
            DashboardPage.OpenPlayground();
            Assert.IsTrue(PlaygroundPage.IsAt(), "Dashboard page is not opened after login action!");
            PlaygroundPage.OpenPeopleTab();
            Assert.IsTrue(PlaygroundPage.IsPeopleTabOpened(), "People tab is not opened!");
            PlaygroundPage.SwitchName();
            Assert.IsTrue(PlaygroundPage.IsNameSwitched(), "Name is not switched!");
        }

        [TestMethod]
        public void Test_1_5_DeletePerson()
        {
            Assert.IsTrue(LoginPage.IsAt(), "Login page is not opened!");
            LoginPage.Login();
            Assert.IsTrue(DashboardPage.IsAt(), "Dashboard page is not opened after login action!");
            DashboardPage.OpenPlayground();
            Assert.IsTrue(PlaygroundPage.IsAt(), "Dashboard page is not opened after login action!");
            PlaygroundPage.OpenPeopleTab();
            Assert.IsTrue(PlaygroundPage.IsPeopleTabOpened(), "People tab is not opened!");
            PlaygroundPage.DeleteAllPersonFromList();
            Assert.IsTrue(PlaygroundPage.AreAllPeopleFromListDeleted(), "List is not deleted!");
        }

    }
}
