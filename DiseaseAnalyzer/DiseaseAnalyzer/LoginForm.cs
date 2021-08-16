using DiseaseAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseaseAnalyzer
{
    public partial class LoginForm : Form
    {
        DiseaseAnalyzerDBContext DBContext = new DiseaseAnalyzerDBContext();
        public LoginForm()
        {
            InitializeComponent();
            textBox1.MaxLength = 100;

            textBox2.MaxLength = 50;

            textBox3.MaxLength = 255;
            textBox3.CharacterCasing = CharacterCasing.Lower;
            textBox3.PasswordChar = '*';

            textBox4.MaxLength = 255;
            textBox4.CharacterCasing = CharacterCasing.Lower;
            textBox4.PasswordChar = '*';

            textBox5.MaxLength = 50;

            textBox6.MaxLength = 255;
            textBox6.CharacterCasing = CharacterCasing.Lower;
            textBox6.PasswordChar = '*';

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Будь ласка заповніть всі поля у секції Sign Up.", "Упс... Щось не так.");
                return;
            }

            string fullName = textBox1.Text;
            string email = textBox2.Text;
            string password1 = textBox3.Text;
            string password2 = textBox4.Text;

            if (DBContext.Patients.Any(item => item.Email == email))
            {
                MessageBox.Show("Користувач з таким емейлом вже існує. Будь ласка, спробуйте увійти у свій акаунт.", "Упс... Щось не так.");
                return;
            }

            if (password1 != password2)
            {
                MessageBox.Show("Будь ласка перевірте пароль.", "Упс... Щось не так.");
                return;
            }

            try
            {
                DBContext.Patients.Add(new Patient() { FullName = fullName, Email = email, Password = password1 });
                DBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка від сервера: " + ex.Message, "Упс... Щось не так.");
                return;
            }


            int currentPatient_ID = DBContext.Patients.First(pat => pat.Email == email).Patient_ID;
            Form1 f1 = new Form1(currentPatient_ID);
            f1.Show();

            ClearTextFields();
            this.Hide();
        }

        private void ClearTextFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" && textBox6.Text == "" )
            {
                MessageBox.Show("Будь ласка заповніть всі поля у секції Sign In.", "Упс... Щось не так.");
                return;
            }

            string email = textBox5.Text;
            string password = textBox6.Text;

            if (!DBContext.Patients.Any(item => item.Email == email))
            {
                MessageBox.Show("Користувача з таким емейлом не існує. Будь ласка перевірте правильність набору, або створіть новий акаунт.", "Упс... Щось не так.");
                return;
            }
            else
            {
                var currentPatient = DBContext.Patients.First(item => item.Email == email);
                if (currentPatient.Password == password)
                {
                    Form1 f1 = new Form1(currentPatient.Patient_ID);
                    f1.Show();

                    ClearTextFields();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильний пароль.", "Упс... Щось не так.");
                    return;
                }
            } 
            
        }
    }
}
