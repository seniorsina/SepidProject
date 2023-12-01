using Models.Model;
using Models.Modle;
using StarterDashbord.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StarterDashbord.Forms;
public partial class AddPlayerForm : Form
{
    public bool IsEditting { get; set; }
    private Player _player;
    public AddPlayerForm()
    {
        InitializeComponent();
        SetMaskedDateEvent();
    }

    public AddPlayerForm(Player player)
    {
        // this should use when Editing
        InitializeComponent();
        _player = player;
        SetMaskedDateEvent();
    }

    private void SetMaskedDateEvent()
    {
        mtxtBirth.Leave += (sender, e) => PersianDateValidator.ValidatePersianDate(sender, errorProvider);
        mtxtEndDate.Leave += (sender, e) => PersianDateValidator.ValidatePersianDate(sender, errorProvider);
    }

    private bool ValidateForm()
    {
        bool isValid = false;
        if (string.IsNullOrEmpty(txtName.Text))
        {
            errorProvider.SetError(txtName, "نام بازیکن را وارد نمایید");
            return isValid;
        }
        else
        {
            errorProvider.SetError(txtName, string.Empty);
        }

        if (string.IsNullOrEmpty(txtLastName.Text))
        {
            errorProvider.SetError(txtLastName, "نام  خانوادگی بازیکن را وارد نمایید");
            return isValid;
        }
        else
        {
            errorProvider.SetError(txtLastName, string.Empty);
        }

        if (string.IsNullOrEmpty(mtxtSocialCode.Text))
        {
            errorProvider.SetError(mtxtSocialCode, "کد ملی را وارد نمایید");
            return isValid;
        }
        else
        {
            errorProvider.SetError(mtxtSocialCode, string.Empty);
        }


        if (string.IsNullOrEmpty(mtxtBirth.Text))
        {
            errorProvider.SetError(mtxtBirth, "تاریخ تولد را وارد نمایید");
            return isValid;
        }
        else
        {
            errorProvider.SetError(mtxtBirth, string.Empty);
        }

        if (string.IsNullOrEmpty(mtxtStartDate.Text))
        {
            errorProvider.SetError(mtxtStartDate, "تاریخ شروع قرار داد را وارد نمایید");
            return isValid;
        }
        else
        {
            errorProvider.SetError(mtxtStartDate, string.Empty);
        }

        if (string.IsNullOrEmpty(mtxtEndDate.Text))
        {
            errorProvider.SetError(mtxtEndDate, "تاریخ اتمام قرار داد را وارد نمایید ");
            return isValid;
        }
        else
        {
            errorProvider.SetError(mtxtEndDate, string.Empty);
        }

        return true;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (IsEditting)
        {
            if (ValidateForm())
            {
                PalyerUpdateDTO updatedPlayer = new PalyerUpdateDTO
                {
                    Id = _player.Id,
                    Name = txtName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    BirthDate = mtxtBirth.Text.Trim(),
                    ContractStartDate = mtxtStartDate.Text.Trim(),
                    ContractEndDate = mtxtEndDate.Text.Trim(),
                    SocialNumber = mtxtSocialCode.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    TeamId = (int)cmbTeamName.SelectedValue
                };

                var response = await Global.ApiClient.PutAsync<PalyerUpdateDTO>(endpoint: "/player", updatedPlayer);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("بازیکن با موفقیت به روز شد.");
                    Close();
                }
                else
                {
                    MessageBox.Show($"به روز کردن بازیکن با شکست مواجه شد. کد وضعیت: {response.StatusCode}");
                }

            }
        }
        else
        {
            if (ValidateForm())
            {
                PalyerDTO p = new PalyerDTO()
                {
                    Name = txtName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    BirthDate = mtxtBirth.Text.Trim(),
                    SocialNumber = mtxtSocialCode.Text.Trim(),
                    TeamId = (int)cmbTeamName.SelectedValue,
                    ContractStartDate = mtxtStartDate.Text.Trim(),
                    ContractEndDate = mtxtEndDate.Text.Trim(),
                    Description = txtDescription.Text.Trim()

                };
                var response = await Global.ApiClient.PostAsync<PalyerDTO>(endpoint: "/player", p);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("بازیکن با موفقیت اضافه شد.");
                    Close();
                }
                else
                {
                    MessageBox.Show($"اضافه کردن بازیکن با خظا مواجه شد. کد وضعیت: {response.StatusCode}");
                }
            }
        }
    }


    private async Task LoadTeamList()
    {
        string endpoint = "/team/idandname";
        var data = await Global.ApiClient.GetAsync<List<TeamIDandName>>(endpoint);
        cmbTeamName.DataSource = data;
        cmbTeamName.DisplayMember = "name";
        cmbTeamName.ValueMember = "id";
    }

    private async void AddPlayerForm_Load(object sender, EventArgs e)
    {
        await LoadTeamList();
        if (IsEditting)
        {
            PreapareForm();
        }
    }

    private void PreapareForm()
    {
        txtName.Text = _player.Name;
        txtLastName.Text = _player.LastName;
        txtDescription.Text = _player.Description;
        mtxtSocialCode.Text = _player.SocialNumber;
        mtxtStartDate.Text = _player.ContractStartDate;
        mtxtEndDate.Text = _player.ContractEndDate;
        mtxtBirth.Text = _player.BirthDate;
        var teamToSelect = cmbTeamName.Items.Cast<TeamIDandName>().FirstOrDefault(team => team.Id == _player.TeamId);
        int index = cmbTeamName.Items.IndexOf(teamToSelect);
        if (index != -1)
        {
            cmbTeamName.SelectedIndex = index;
        }

    }
}
