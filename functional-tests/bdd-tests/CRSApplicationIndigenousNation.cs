﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using Xunit;

/*
Feature: CRSApplication_indigenousnation
    As a logged in business user
    I want to submit a CRS Application for an indigenous nation

Scenario: Start Application
    Given I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button
    And I click on the Continue to Organization Review button
    And I complete the application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And I delete my account
    Then I see login
*/

namespace bdd_tests
{
    [FeatureFile("./CRSApplication_indigenousnation.feature")]
    public sealed class CRSApplicationIndigenousNation : TestBaseCRS
    {
        [Given(@"I am logged in to the dashboard as an (.*)")]
        public void I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Start Application button")]
        public void I_start_application()
        {
            /* 
            Page Title: Welcome to Cannabis Licensing
            */

            NgWebElement startApp_button = ngDriver.FindElement(By.XPath("//button[text()='START APPLICATION']"));
            startApp_button.Click();

            /* 
            Page Title: Cannabis Retail Store Licence Eligibility Disclosure
            */

            string electricSignature = "Automated Test";

            // select No for Question 1
            NgWebElement noRadio1 = ngDriver.FindElement(By.Id("mat-radio-3"));
            noRadio1.Click();

            // select No for Question 2
            NgWebElement noRadio2 = ngDriver.FindElement(By.Id("mat-radio-9"));
            noRadio2.Click();

            // select the certification checkbox
            NgWebElement matCheckbox = ngDriver.FindElement(By.Id("mat-checkbox-1"));
            matCheckbox.Click();

            // enter the electronic signature
            NgWebElement sigCheckbox = ngDriver.FindElement(By.Id("eligibilitySignature"));
            sigCheckbox.SendKeys(electricSignature);

            // click on the Submit button
            NgWebElement submit_button = ngDriver.FindElement(By.XPath("//button[text()='SUBMIT']"));
            submit_button.Click();

            /* 
            Page Title: Please Review the Account Profile
            */

            // Complete account profile page

            string bizNumber = "012345678";
            string streetAddress = "645 Tyee Road";
            string city = "Victoria";
            string postalCode = "V8V4Y3";
            string bizPhoneNumber = "2501811818";
            string bizEmail = "test@automation.com";
            string corpContactPhone = "7781811818";
            string corpContactEmail = "automated@test.com";
            
            NgWebElement uiBizNumber = ngDriver.FindElement(By.XPath("(//input[@type='text'])[2]"));
            uiBizNumber.SendKeys(bizNumber);

            NgWebElement uiStreetAddress = ngDriver.FindElement(By.XPath("(//input[@type='text'])[3]"));
            uiStreetAddress.SendKeys(streetAddress);

            NgWebElement uiCity = ngDriver.FindElement(By.XPath("(//input[@type='text'])[5]"));
            uiCity.SendKeys(city);

            NgWebElement uiPostalCode = ngDriver.FindElement(By.XPath("(//input[@type='text'])[7]"));
            uiPostalCode.SendKeys(postalCode);

            NgWebElement uiSameAsMailingAddress = ngDriver.FindElement(By.XPath("//input[@type='checkbox']"));
            uiSameAsMailingAddress.Click();

            NgWebElement uiBizPhoneNumber = ngDriver.FindElement(By.XPath("(//input[@type='text'])[15]"));
            uiBizPhoneNumber.SendKeys(bizPhoneNumber);

            NgWebElement uiBizEmail = ngDriver.FindElement(By.XPath("(//input[@type='text'])[16]"));
            uiBizEmail.SendKeys(bizEmail);

            NgWebElement uiCorpContactPhone = ngDriver.FindElement(By.XPath("(//input[@type='text'])[20]"));
            uiCorpContactPhone.SendKeys(corpContactPhone);

            NgWebElement uiCorpContactEmail = ngDriver.FindElement(By.XPath("(//input[@type='text'])[21]"));
            uiCorpContactEmail.SendKeys(corpContactEmail);

            NgWebElement corpConnectionFederalProducer = ngDriver.FindElement(By.XPath("(//input[@type='radio'])[2]"));
            corpConnectionFederalProducer.Click();

            NgWebElement continueApp_button = ngDriver.FindElement(By.Id("continueToApp"));
            continueApp_button.Click();
        }

        [And(@"I click on the Continue to Organization Review button")]
        public void I_continue_to_organization_review()
        {
            // click on the Submit Org Info button
            NgWebElement submitOrgInfoButton = ngDriver.FindElement(By.XPath("//button[text()=' SUBMIT ORGANIZATION INFORMATION']"));
            submitOrgInfoButton.Click();
        }

        [And(@"I complete the application")]
        public void I_complete_the_application()
        {
            string estName = "Point Ellis Greenhouse";
            string estAddress = "645 Tyee Rd";
            string estCity = "Victoria";
            string estPostal = "V9A6X5";
            string estPID = "012345678";
            string estEmail = "test@test.com";
            string estPhone = "2505555555";
            string conGiven = "Given";
            string conSurname = "Surname";
            string conRole = "CEO";
            string conPhone = "2508888888";
            string conEmail = "contact@email.com";
            string indigenousNation = "Ashcroft Indian Band";

            NgWebElement uiSelectNation = ngDriver.FindElement(By.XPath("/html/body/app-root/div/div/div/main/div/app-multi-stage-application-flow/div/mat-horizontal-stepper/div[2]/div[3]/app-application/div/div[2]/div[2]/section/div/app-field[2]/section/div[1]/section/select"));
            uiSelectNation.SendKeys(indigenousNation);

            NgWebElement estabName = ngDriver.FindElement(By.Id("establishmentName"));
            estabName.SendKeys(estName);

            NgWebElement estabAddress = ngDriver.FindElement(By.Id("establishmentAddressStreet"));
            estabAddress.SendKeys(estAddress);

            NgWebElement estabCity = ngDriver.FindElement(By.Id("establishmentAddressCity"));
            estabCity.SendKeys(estCity);

            NgWebElement estabPostal = ngDriver.FindElement(By.Id("establishmentAddressPostalCode"));
            estabPostal.SendKeys(estPostal);

            NgWebElement estabPID = ngDriver.FindElement(By.Id("establishmentParcelId"));
            estabPID.SendKeys(estPID);

            NgWebElement estabEmail = ngDriver.FindElement(By.Id("establishmentEmail"));
            estabEmail.SendKeys(estEmail);

            NgWebElement estabPhone = ngDriver.FindElement(By.Id("establishmentPhone"));
            estabPhone.SendKeys(estPhone);

            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            string signagePath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
            NgWebElement uploadSignage = ngDriver.FindElement(By.XPath("(//input[@type='file'])[2]"));
            uploadSignage.SendKeys(signagePath);

            string validInterestPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "valid_interest.pdf");
            NgWebElement uploadValidInterest = ngDriver.FindElement(By.XPath("(//input[@type='file'])[6]"));
            uploadValidInterest.SendKeys(validInterestPath);

            string floorplanPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "floor_plan.pdf");
            NgWebElement uploadFloorplan = ngDriver.FindElement(By.XPath("(//input[@type='file'])[8]"));
            uploadFloorplan.SendKeys(floorplanPath);

            string sitePlanPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "site_plan.pdf");
            NgWebElement uploadSitePlan = ngDriver.FindElement(By.XPath("(//input[@type='file'])[11]"));
            uploadSitePlan.SendKeys(sitePlanPath);

            string finIntegrityPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "fin_integrity.pdf");
            NgWebElement uploadFinIntegrity = ngDriver.FindElement(By.XPath("(//input[@type='file'])[15]"));
            uploadFinIntegrity.SendKeys(finIntegrityPath);

            NgWebElement contactGiven = ngDriver.FindElement(By.Id("contactPersonFirstName"));
            contactGiven.SendKeys(conGiven);

            NgWebElement contactSurname = ngDriver.FindElement(By.Id("contactPersonLastName"));
            contactSurname.SendKeys(conSurname);

            NgWebElement contactRole = ngDriver.FindElement(By.CssSelector("input[formControlName=contactPersonRole]"));
            contactRole.SendKeys(conRole);

            NgWebElement contactPhone = ngDriver.FindElement(By.CssSelector("input[formControlName=contactPersonPhone]"));
            contactPhone.SendKeys(conPhone);

            NgWebElement contactEmail = ngDriver.FindElement(By.Id("contactPersonEmail"));
            contactEmail.SendKeys(conEmail);

            NgWebElement authorizedSubmit = ngDriver.FindElement(By.Id("authorizedToSubmit"));
            authorizedSubmit.Click();

            NgWebElement signatureAgree = ngDriver.FindElement(By.Id("signatureAgreement"));
            signatureAgree.Click();
        }

        [And(@"I click on the Submit button")]
        public void click_on_submit_button()
        {
            NgWebElement submit_button = ngDriver.FindElement(By.XPath("//button[contains(.,'SUBMIT')]"));
            System.Threading.Thread.Sleep(7000);

            submit_button.Click();
            System.Threading.Thread.Sleep(7000);
        }

        [And(@"I click on the Pay for Application button")]
        public void click_on_pay_for_application()
        {
            NgWebElement pay_button = ngDriver.FindElement(By.XPath("//button[contains(.,'Pay for Application')]"));
            System.Threading.Thread.Sleep(7000);

            pay_button.Click();
            System.Threading.Thread.Sleep(7000);
        }

        [And(@"I enter the payment information")]
        public void enter_payment_info()
        {
            MakeCRSPayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            /* 
            Page Title: Payment Approved
            */

            // confirm that payment receipt is for $7,500.00
            Assert.True (ngDriver.FindElement(By.XPath("/html/body/app-root/div/div/div/main/div/app-payment-confirmation/mat-card/div/div[1]/div/div/table/tr[6]/td[2][text()='$7,500.00']")).Displayed);

            string retDash = "Return to Dashboard";
            NgWebElement returnDash = ngDriver.FindElement(By.LinkText(retDash));
            returnDash.Click();
        }

        [And(@"I delete my account")]
        public void Delete_my_account()
        {
            this.CarlaDeleteCurrentAccount();
        }

        [Then(@"I see login")]
        public void I_see_login()
        {
            Assert.True (ngDriver.FindElement(By.XPath("//a[text()='Log In']")).Displayed);
        }
    }
}
