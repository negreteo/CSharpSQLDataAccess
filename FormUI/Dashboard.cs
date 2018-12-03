using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
  public partial class Dashboard : Form
  {
    List<Person> people = new List<Person>();

    public Dashboard()
    {
      InitializeComponent();
      UpdateBinding();

    }

    private void UpdateBinding()
    {
      peopleFoundListBox.DataSource = people;
      peopleFoundListBox.DisplayMember = "FullInfo";
    }


    private void Dashboard_Load(object sender, EventArgs e)
    {

    }

    private void searchButton_Click(object sender, EventArgs e)
    {
      DataAcccess db = new DataAcccess();

      people = db.GetPeople(lastNameText.Text);
      UpdateBinding();
    }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailInsText.Text, phoneInsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailInsText.Text = "";
            phoneInsText.Text = "";
        }
    }
}
