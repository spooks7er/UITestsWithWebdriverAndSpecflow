namespace UITesting.Mobilebg.Core.PageModels
{
    using System;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class AccountBalancePage : BasePage
    {
        public AccountBalancePage(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Slides the slider on this page by a given offset in percentage
        /// </summary>
        /// <param name="offset">Percentage offset</param>
        public void SliderSlider(double offset)
        {
            int baseSize = SliderBar.Size.Width;
            var element = SliderDot;
            double offsetAdj = baseSize * ((offset / 100.0) - 0.046465);
            Actions action = new Actions(Driver);
            IAction dragAndDrop = action
                .ClickAndHold(element)
                .MoveByOffset(Convert.ToInt32(offsetAdj), 0)
                .Release()
                .Build();
            dragAndDrop.Perform();
        }

        /// <summary>
        /// Sets the payment Option on this page
        /// </summary>
        /// <param name="option">The selected payment option</param>
        public void SelectPayment(string option)
        {
            var labels = PaymentForm.FindElements(By.TagName("label"));
            var labelOption = labels.FirstOrDefault(l => l.Text.Contains(option));
            labelOption.Click();
        }
    }
}