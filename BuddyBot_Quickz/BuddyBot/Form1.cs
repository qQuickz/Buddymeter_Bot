using MSHTML;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuddyBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWebDriver driver = new ChromeDriver();
        ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        //javascript:questionArray[question_number].answer

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            driver.Manage().Window.Maximize();
            service.HideCommandPromptWindow = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("buddymeter"))
            {
                driver.Navigate().GoToUrl(textBox1.Text);
                label5.Text = "Host: " + driver.FindElement(By.ClassName("quiz_name")).Text;
                label5.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Please Enter a Buddymeter link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            driver.Close();
        }

        private void GetAnswer()
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("javascript:alert(questionArray[question_number].answer)"); //Javascript inject
            try
            {
                string text = driver.FindElement(By.XPath("//input[@value = 'alert']")).ToString();
            }
            catch (Exception zahl)//Finds the answer for question
            {
                SendKeys.Send("{ENTER}");
                string input = zahl.ToString();
                string digits = new String(input.Take(85).ToArray());
                string resultString = Regex.Match(digits, @"\d+").Value;
                Clipboard.SetText(resultString);
                System.Threading.Thread.Sleep(Convert.ToInt16(25));
            }
        }
        private void button5_Click(object sender, EventArgs e)
        { 
            //Automated Javscipt inject and Answer-Sort
            driver.Manage().Window.Maximize();
            TopMost = true;
            driver.FindElement(By.Name("text_option_2")).SendKeys(textBox2.Text);
            driver.FindElement(By.Id("name_button")).Click();
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") "+ driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.ForeColor = Color.Green;
            label4.Text = "1/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "2/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "3/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "4/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value)); 
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "5/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "6/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "7/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "8/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "9/10";
            System.Threading.Thread.Sleep(Convert.ToInt16(speed.Value));
            GetAnswer();
            driver.FindElement(By.Id("option_" + Clipboard.GetText())).Click();
            listView1.Items.Add(driver.FindElement(By.Id("question")).Text).SubItems.Add(" (" + Clipboard.GetText() + ") " + driver.FindElement(By.Id("option_" + Clipboard.GetText())).Text);
            label4.Text = "10/10";
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("chrome://settings/clearBrowserData"); //Clear Cookie 
            listView1.Items.Clear();
            label4.Text = "0/10";
            label4.ForeColor = Color.Black;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
