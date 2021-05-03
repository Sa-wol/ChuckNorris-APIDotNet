using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void jokeButton_Click(object sender, EventArgs e)
        {
            Joke getJoke = await ChuckNorrisClient.GetRandomJoke();
            var randomJoke = getJoke.JokeText;
            MessageBox.Show(randomJoke);
        }

        private async void ChuckNorrisForm_Load(object sender, EventArgs e)
        {
            IEnumerable<string> getJokeCategories = await ChuckNorrisClient.GetCategories();
            foreach (string category in getJokeCategories)
            {
                jokeComboBox.Items.Add(category);
            }
        }
    }
}
