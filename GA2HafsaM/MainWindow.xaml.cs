using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GA2HafsaM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Display Full Name - Message Box
        private void btnFullName_Click(object sender, RoutedEventArgs e)
        {
            //create string variables
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            //Combine string variable
            string fullName = $"{firstName} {lastName}";

            //put into messagebox for result
            MessageBox.Show(fullName);

        } //btnFullName_Click


          
        //Perform a Calculation - Label
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //create string variables
            string number1= txtNumber1.Text;
            string number2= txtNumber2.Text;

            //create new variables to parse to make it into math 
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            //create signs for readablity
            string sign = "+";
            string equalSign = "=";

            //combine string variable to make it easy for result
            int result = num1 + num2;
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            //display the equation with label "sign"
            lblEquation.Content = equation;
        }
        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            //create string variables
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;

            //create new variables to parse to make it into math 
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            //create signs for readablity
            string sign = "-";
            string equalSign = "=";

            //combine string variable to make it easy for result
            int result = num1 - num2;
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            //display the equation with label "sign"
            lblEquation.Content = equation;
        }


        //Display a letter from a word - textbox
        private void btnDisplayLetter_Click(object sender, RoutedEventArgs e)
        {
            //create a variable to hold the text from txtWord
            string userWord = txtWord.Text;

            //ctreate a variable to get the text from tstCharIndex
            string index = txtDisplayLetter.Text;

            //parsing the word in one line 
            int usersNumber = int.Parse(index);
            char selectedChar = index[usersNumber];

            txtDisplayLetter.Text = selectedChar.ToString();

        } //btnDisplayLetter_Click

        private void txtWord_TextChanged(object sender, TextChangedEventArgs e)
        {
            //getting users word out
            string usersWord = txtWord.Text;

            //getting how many characters are in a word
            int stringLength = usersWord.Length;

            //getting the last index of the word left
            int lastIndex = stringLength - 1;

            //displaying the range of 0 to the last index
            string formattedString = $"Enter a number between 0 and {lastIndex}";

            //displaying it to our label
            lblNumberOfLetters.Content = formattedString;

        } //txtWord_TextChanged
    }
}
