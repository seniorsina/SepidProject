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

    }

    private void ClearPanel()
    {
        foreach (Control control in pnlFormLoader.Controls)
        {
            control.Dispose();
        }
        pnlFormLoader.Controls.Clear();
    }

    private void InitializeForm<T>(T form) where T : Form
    {
        form.Dock = DockStyle.Fill;
        form.FormBorderStyle = FormBorderStyle.None;
        form.TopLevel = false;
        form.TopMost = true;
        form.Show();
        this.pnlFormLoader.Controls.Add(form);
    }

    private void btnDashboard_Leave(object sender, EventArgs e)
    {

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


    private void btnDashboard_Click(object sender, EventArgs e)
    {

    }

    private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
    {

    }

    private async void MainFrom_Load(object sender, EventArgs e)
    {
        LoadTeamList();
    }

    private async void LoadTeamList()
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
        dataGridView.Columns["id"].HeaderText = "شناسه";
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
        LoadTeamList();
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
        LoadTeamList();

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
            var selectedTeamId = dgvTeam.SelectedRows[0].Cells["Id"].Value;
            var response = await Global.ApiClient.DeleteAsync($"/team/{selectedTeamId}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("تیم با موفقیت حذف شد");
                LoadTeamList();

            }
            else
            {
                MessageBox.Show("هنگام حذف تیم خطایی رخ داد.");
            }
        }
        else
        {
            MessageBox.Show("هیچ تیمی انتخاب نشده است");
        }
    }
}

