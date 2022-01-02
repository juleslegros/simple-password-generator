
// Simple Password Generator By Jules Legros
// Créer par Jules Legros le 02/01/2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Simple_Password_Generator_By_Jules_Legros

{
    public partial class Password_Generator : Form
    {
        
        int currentPasswordLenght = 0;
        Random character = new Random();

        private void passwordGenerator(int passwordLenght)
        {
            
            string allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz+_)(*&^%$#@!-={}][':;?><,./";
            string randomPassword = "";

            for(int i=0; i < passwordLenght; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            Password.Text = randomPassword;
        }







        public Password_Generator()
        {
            InitializeComponent();
            Slider.Minimum = 5;
            Slider.Maximum = 32;
            passwordGenerator(5);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Slider_Scroll(object sender, EventArgs e)
        {
           
            SliderLabel.Text = Slider.Value.ToString();
            currentPasswordLenght = Slider.Value;
            passwordGenerator(currentPasswordLenght);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Password.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = "https://github.com/juleslegros";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Jules Legros");
        }

        private void LinkedinBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = "https://fr.linkedin.com/in/jules-legros";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Vous êtes sûr de vouloir fermer cette application ?", "Confirmation de fermeture",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;

            }
    }
    }
}
