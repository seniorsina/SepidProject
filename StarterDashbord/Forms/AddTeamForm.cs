using Models.Model;
using Models.Modle;
using Newtonsoft.Json;
using StarterDashbord.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarterDashbord.Forms;
public partial class AddTeamForm : Form
{
    private Team _team;
    public bool IsEditting { get; set; }

    public AddTeamForm()
    {
        InitializeComponent();
        mtxtCreateDate.Leave += (sender, e) => PersianDateValidator.ValidatePersianDate(sender, errorProvider);
    }

    public AddTeamForm(Team t)
    {
        InitializeComponent();
        mtxtCreateDate.Leave += (sender, e) => PersianDateValidator.ValidatePersianDate(sender, errorProvider);
        this._team = t;
    }


    private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
    {

    }


    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private async void AddTeamForm_Load(object sender, EventArgs e)
    {
        await LoadTeamType();
        await LoadGradeList();
        await LoadColorList();
          if (IsEditting)
        {
            PreapareForm();
        }
    }

    private void PreapareForm()
    {
        txtTeamName.Text = _team.Name;
        mtxtCreateDate.Text = _team.EstablishmentِDate;
        ritxtDescription.Text = _team.Description;
        int index = cmbFirstColor.FindStringExact(_team.FirstColor);
        if (index != -1)
        {
            cmbFirstColor.SelectedIndex = index;
        }
        index = cmbSecondColor.FindStringExact(_team.SecondColor);
        if (index != -1)
        {
            cmbSecondColor.SelectedIndex = index;
        }
        index = cmbTeamType.FindStringExact(_team.TeamType);
        if (index != -1)
        {
            cmbTeamType.SelectedIndex = index;
        }

        index = cmbGrade.FindStringExact(_team.Grade);
        if (index != -1)
        {
            cmbGrade.SelectedIndex = index;
        }

    }

    private async Task  LoadColorList()
    {
        string endpoint = "/sysList/1";
        var data = await Global.ApiClient.GetAsync<List<SysList>>(endpoint);
        cmbFirstColor.DataSource = new List<SysList>(data);
        cmbSecondColor.DataSource = new List<SysList>(data);
        cmbFirstColor.DisplayMember = "val";
        cmbSecondColor.DisplayMember = "val";
    }

    private async Task  LoadGradeList()
    {
        string endpoint = "/sysList/3";
        var data = await Global.ApiClient.GetAsync<List<SysList>>(endpoint);
        cmbGrade.DataSource = data;
        cmbGrade.DisplayMember = "val";
    }

    private async Task LoadTeamType()
    {
        string endpoint = "/sysList/2";
        var data = await Global.ApiClient.GetAsync<List<SysList>>(endpoint);
        cmbTeamType.DataSource = data;
        cmbTeamType.DisplayMember = "val";
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (IsEditting)
        {
            Team updatedTeam = new Team
            {
                Id = _team.Id,
                Name = txtTeamName.Text.Trim(),
                EstablishmentِDate = mtxtCreateDate.Text.Trim(),
                TeamType = cmbTeamType.Text.Trim(),
                Grade = cmbGrade.Text.Trim(),
                FirstColor = cmbFirstColor.Text.Trim(),
                SecondColor = cmbSecondColor.Text.Trim(),
                Description = ritxtDescription.Text.Trim(),
                Players = new List<Player>()  // this will not be updated in database API handle it
            };

            var response = await Global.ApiClient.PutAsync<Team>(endpoint: "/team", updatedTeam);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("تیم با موفقیت اضافه شد.");
                Close();
            }
            else
            {
                MessageBox.Show($"اضافه کردن تیم با خطا مواجه شد. کد وضعیت: {response.StatusCode}");
            }

        }
        else
        {
            // check form is valid 
            TeamDto t = new TeamDto()
            {
                Name = txtTeamName.Text.Trim(),
                EstablishmentِDate = mtxtCreateDate.Text.Trim(),
                TeamType = cmbTeamType.Text.Trim(),
                Grade = cmbGrade.Text.Trim(),
                FirstColor = cmbFirstColor.Text.Trim(),
                SecondColor = cmbSecondColor.Text.Trim(),
                Description = ritxtDescription.Text.Trim(),

            };
            var response = await Global.ApiClient.PostAsync<TeamDto>(endpoint: "/team", t);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("تیم با موفقیت اضافه شد.");
                Close();
            }
            else
            {
                MessageBox.Show($"اضافه کردن تیم با شکست مواجه شد. کد وضعیت: {response.StatusCode}");
            }
        }
    }
}
