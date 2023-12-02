using Models.Model;
using StarterDashbord.ClassLibrary;
using StarterDashbord.Forms;
using System.Windows.Forms;
namespace StarterDashbord;

public partial class MainFrom : Form
{

    public MainFrom()
    {
        InitializeComponent();
        this.dgvTeam.MouseWheel += new MouseEventHandler(this.dvg_MouseWheel);
        this.dgvPlayers.MouseWheel += new MouseEventHandler(this.dvgPlayer_MouseWheel);

    }



    private void dvgPlayer_MouseWheel(object sender, MouseEventArgs e)
    {
        try
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) return;

            int firstVisibleColumnIndex = dataGridView.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index;

            if (e.Delta > 0 && dataGridView.CurrentRow.Index > 0)
            {
                dataGridView.CurrentCell = dataGridView[firstVisibleColumnIndex, dataGridView.CurrentRow.Index - 1];
            }
            else if (e.Delta < 0 && dataGridView.CurrentRow.Index < dataGridView.RowCount - 1)
            {
                dataGridView.CurrentCell = dataGridView[firstVisibleColumnIndex, dataGridView.CurrentRow.Index + 1];
            }
        }
        catch (Exception ex)
        {
            //  MessageBox.Show(ex.Message);
        }

    }


    private void dvg_MouseWheel(object sender, MouseEventArgs e)
    {
        try
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) return;

            if (e.Delta > 0 && dataGridView.CurrentRow.Index > 0)
            {
                dataGridView.CurrentCell = dataGridView[0, dataGridView.CurrentRow.Index - 1];
            }
            else if (e.Delta < 0 && dataGridView.CurrentRow.Index < dataGridView.RowCount - 1)
            {
                dataGridView.CurrentCell = dataGridView[0, dataGridView.CurrentRow.Index + 1];
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }




    private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
    {

    }

    private async Task PrepareBothGrid()
    {
        await LoadTeamList();
        var playerTeamID = (int)dgvTeam.SelectedRows[0].Cells["Id"].Value;
      await  LoadPlayerByTeam(playerTeamID);
        
    }

    private async void MainFrom_Load(object sender, EventArgs e)
    {
       await PrepareBothGrid();
       
        if (dgvPlayers.SelectedRows.Count > 0)
        {
            var row = dgvPlayers.SelectedRows[0];
            if (row.Cells["description"].Value != null)
            {
                ritxtPlayerDescription.Text = row.Cells["description"].Value.ToString();
            }
            else ritxtTeamDescription.Text = "";
        }
    }

    private async Task LoadTeamList()
    {
        dgvTeam.SelectionChanged -= dgvTeam_SelectionChanged;
        string endpoint = "/team";
        var data = await Global.ApiClient.GetAsync<List<Team>>(endpoint);

        dgvTeam.DataSource = data;
        SetTeamGridHeader(dgvTeam);
        dgvTeam.SelectionChanged += dgvTeam_SelectionChanged;
    }

    public void SetTeamGridHeader(DataGridView dataGridView)
    {
        dataGridView.Columns["id"].HeaderText = "کد تیم";
        dataGridView.Columns["name"].HeaderText = "نام";
        dataGridView.Columns["establishmentِDate"].HeaderText = "تاریخ تاسیس";
        dataGridView.Columns["teamType"].HeaderText = "نوع تیم";
        dataGridView.Columns["grade"].HeaderText = "رتبه";
        dataGridView.Columns["firstColor"].HeaderText = "رنگ اول";
        dataGridView.Columns["secondColor"].HeaderText = "رنگ دوم";
        dataGridView.Columns["description"].HeaderText = "توضیحات";
        dataGridView.Columns["players"].HeaderText = "بازیکنان";

        foreach (DataGridViewColumn column in dataGridView.Columns)
        {
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        dataGridView.Columns["players"].Visible = false;
        dataGridView.Columns["description"].Visible = false;
    }

    private void dgvTeam_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvTeam.SelectedRows.Count > 0)
        {
            var row = dgvTeam.SelectedRows[0];

            if (row.Cells["description"].Value != null)
            {
                ritxtTeamDescription.Text = row.Cells["description"].Value.ToString();
            }
            else ritxtTeamDescription.Text = "";
            ritxtPlayerDescription.Text = "";
            var playerTeamID = (int)dgvTeam.SelectedRows[0].Cells["Id"].Value;
            LoadPlayerByTeam(playerTeamID);
        }
    }

    private void btnAddTeam_Click(object sender, EventArgs e)
    {
        AddTeamForm addTeamFrom = new AddTeamForm()
        {
            IsEditting = false,
            Text = "تیم جدید",
            StartPosition = FormStartPosition.CenterParent
        };

        addTeamFrom.ShowDialog();
        PrepareBothGrid();
    }

    private void btnEditTeam_Click(object sender, EventArgs e)
    {
        var t = GetSelectedTeam(dgvTeam);
        AddTeamForm editTeamFrom = new AddTeamForm(t)
        {
            IsEditting = true,
            Text = "ویرایش تیم",
            StartPosition = FormStartPosition.CenterParent
        };
        editTeamFrom.ShowDialog();
        PrepareBothGrid();

    }

    private Team GetSelectedTeam(DataGridView dataGridView)
    {
        if (dataGridView.SelectedRows.Count == 0)
        {
            return null;
        }

        var selectedRow = dataGridView.SelectedRows[0];

        Team team = new Team()
        {
            Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
            Name = selectedRow.Cells["Name"].Value.ToString(),
            EstablishmentِDate = selectedRow.Cells["EstablishmentِDate"].Value.ToString(),
            TeamType = selectedRow.Cells["TeamType"].Value.ToString(),
            Grade = selectedRow.Cells["Grade"].Value.ToString(),
            FirstColor = selectedRow.Cells["FirstColor"].Value.ToString(),
            SecondColor = selectedRow.Cells["SecondColor"].Value.ToString(),
            Description = selectedRow.Cells["Description"].Value == null ? null : selectedRow.Cells["Description"].Value.ToString(),

            Players = new List<Player>()
        };

        return team;
    }

    private async void btnDeleteTeam_Click(object sender, EventArgs e)
    {
        if (dgvTeam.SelectedRows.Count > 0)
        {
            DialogResult dialogResult = MessageBox.Show("با حذف تیم تمام بازیکنان تیم حذف خواهند شد ایا ادامه می دهید؟", "تأیید حذف", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var selectedTeamId = (int)dgvTeam.SelectedRows[0].Cells["Id"].Value;
                var response = await Global.ApiClient.DeleteAsync($"/team/{selectedTeamId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("تیم با موفقیت حذف شد");
                    PrepareBothGrid();

                }
                else
                {
                    MessageBox.Show("هنگام حذف تیم خطایی رخ داد.");
                }

            }

        }
        else
        {
            MessageBox.Show("هیچ تیمی انتخاب نشده است");
        }
    }

    private void btnNewPlayer_Click(object sender, EventArgs e)
    {
        AddPlayerForm addPlayerForm = new AddPlayerForm()
        {
            IsEditting = false,
            StartPosition =  FormStartPosition.CenterParent,
            Text = "بازیکن جدید"
        };
        addPlayerForm.Show();
        PrepareBothGrid();
    }

    private async void button3_Click(object sender, EventArgs e)
    {
        if (dgvPlayers.SelectedRows.Count > 0)
        {
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید که می خواهید بازیکن را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var selectedPlayerID = dgvPlayers.SelectedRows[0].Cells["Id"].Value;
                var playerTeamID = (int)dgvTeam.SelectedRows[0].Cells["Id"].Value;
                var response = await Global.ApiClient.DeleteAsync($"/player/{selectedPlayerID}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("بازیکن با موفقیت حذف شد");
                    PrepareBothGrid();
                }
                else
                {
                    MessageBox.Show("هنگام حذف بازیکن خطایی رخ داد.");
                }
            }

        }
        else
        {
            MessageBox.Show("هیچ بازیکنی انتخاب نشده است");
        }
    }

    private async Task LoadPlayerByTeam(int playerTeamID)
    {
        dgvPlayers.SelectionChanged -= dgvPlayers_SelectionChanged;
        string endpoint = "/Player/" + playerTeamID.ToString();
        var data = await Global.ApiClient.GetAsync<List<Player>>(endpoint);

        dgvPlayers.DataSource = data;
        SetPlayerGridHeader(dgvPlayers);
        dgvPlayers.SelectionChanged += dgvPlayers_SelectionChanged;
       

     
    }

    private void SetPlayerGridHeader(DataGridView dgv)
    {

        dgv.Columns["name"].HeaderText = "نام";
        dgv.Columns["lastName"].HeaderText = "نام خانوادگی";
        dgv.Columns["birthDate"].HeaderText = "تاریخ تولد";
        dgv.Columns["contractStartDate"].HeaderText = "تاریخ شروع قرارداد";
        dgv.Columns["contractEndDate"].HeaderText = "تاریخ پایان قرارداد";
        dgv.Columns["socialNumber"].HeaderText = "کد ملی";

        dgv.Columns["id"].Visible = false;
        dgv.Columns["teamId"].Visible = false;
        dgv.Columns["team"].Visible = false;
        dgv.Columns["description"].Visible = false;
    }


    private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvPlayers.SelectedRows.Count > 0)
        {
            var row = dgvPlayers.SelectedRows[0];

            if (row.Cells["description"].Value != null)
            {
                ritxtPlayerDescription.Text = row.Cells["description"].Value.ToString();
            }
            else ritxtTeamDescription.Text = "";

        }

    }



    private void btnEditPlayer_Click(object sender, EventArgs e)
    {
        if (dgvPlayers.SelectedRows.Count > 0)
        {
            Player p = CreatePlayerFromSelectedRow(dgvPlayers);
            AddPlayerForm frm = new AddPlayerForm(p)
            {
                IsEditting = true,
                Text = "ویرایش بازیکن",
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
            PrepareBothGrid();
        }
    }

    private Player CreatePlayerFromSelectedRow(DataGridView dgv)
    {
        var row = dgv.SelectedRows[0];
        return new Player
        {
            Id = (int)row.Cells["id"].Value,
            Name = (string)row.Cells["name"].Value,
            LastName = (string)row.Cells["lastName"].Value,
            BirthDate = (string)row.Cells["birthDate"].Value,
            ContractStartDate = (string)row.Cells["contractStartDate"].Value,
            ContractEndDate = (string)row.Cells["contractEndDate"].Value,
            SocialNumber = (string)row.Cells["socialNumber"].Value,
            Description = (string)row.Cells["description"].Value,
            TeamId = (int?)row.Cells["teamId"].Value
        };
    }

}

