
namespace StarterDashbord;

partial class MainFrom
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
        topPanel = new Panel();
        label2 = new Label();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        pnlFormLoader = new Panel();
        splitContainer1 = new SplitContainer();
        dgvTeam = new DataGridView();
        panel1 = new Panel();
        grbTeam = new GroupBox();
        ritxtTeamDescription = new RichTextBox();
        panel2 = new Panel();
        btnDeleteTeam = new Button();
        btnEditTeam = new Button();
        btnAddTeam = new Button();
        dgvPlayers = new DataGridView();
        groupBox1 = new GroupBox();
        ritxtPlayerDescription = new RichTextBox();
        panel3 = new Panel();
        button3 = new Button();
        btnEditPlayer = new Button();
        btnNewPlayer = new Button();
        topPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        pnlFormLoader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTeam).BeginInit();
        panel1.SuspendLayout();
        grbTeam.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
        groupBox1.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // topPanel
        // 
        topPanel.BackColor = Color.FromArgb(20, 20, 20);
        topPanel.Controls.Add(label2);
        topPanel.Controls.Add(label1);
        topPanel.Controls.Add(pictureBox1);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(959, 53);
        topPanel.TabIndex = 0;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = SystemColors.ButtonHighlight;
        label2.Location = new Point(3, 18);
        label2.Name = "label2";
        label2.Size = new Size(130, 21);
        label2.TabIndex = 2;
        label2.Text = "پنل مدیریت بازیکن";
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.Location = new Point(789, 18);
        label1.Name = "label1";
        label1.Size = new Size(105, 21);
        label1.TabIndex = 1;
        label1.Text = " پنل مدیرت تیم";
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Right;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(894, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(65, 53);
        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // pnlFormLoader
        // 
        pnlFormLoader.BackColor = Color.FromArgb(40, 40, 40);
        pnlFormLoader.Controls.Add(splitContainer1);
        pnlFormLoader.Dock = DockStyle.Fill;
        pnlFormLoader.Location = new Point(0, 53);
        pnlFormLoader.Name = "pnlFormLoader";
        pnlFormLoader.Size = new Size(959, 468);
        pnlFormLoader.TabIndex = 10;
        pnlFormLoader.Paint += pnlFormLoader_Paint;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(dgvTeam);
        splitContainer1.Panel1.Controls.Add(panel1);
        splitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
        splitContainer1.Panel1MinSize = 500;
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(dgvPlayers);
        splitContainer1.Panel2.Controls.Add(groupBox1);
        splitContainer1.Panel2.Controls.Add(panel3);
        splitContainer1.Panel2.RightToLeft = RightToLeft.Yes;
        splitContainer1.Size = new Size(959, 468);
        splitContainer1.SplitterDistance = 500;
        splitContainer1.TabIndex = 0;
        // 
        // dgvTeam
        // 
        dgvTeam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTeam.Dock = DockStyle.Fill;
        dgvTeam.Location = new Point(0, 0);
        dgvTeam.MultiSelect = false;
        dgvTeam.Name = "dgvTeam";
        dgvTeam.RowTemplate.Height = 25;
        dgvTeam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTeam.Size = new Size(500, 352);
        dgvTeam.TabIndex = 4;
        dgvTeam.SelectionChanged += dgvTeam_SelectionChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(grbTeam);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 352);
        panel1.Name = "panel1";
        panel1.Size = new Size(500, 116);
        panel1.TabIndex = 5;
        // 
        // grbTeam
        // 
        grbTeam.Controls.Add(ritxtTeamDescription);
        grbTeam.Dock = DockStyle.Bottom;
        grbTeam.ForeColor = SystemColors.ButtonHighlight;
        grbTeam.Location = new Point(0, 10);
        grbTeam.Name = "grbTeam";
        grbTeam.Size = new Size(500, 57);
        grbTeam.TabIndex = 0;
        grbTeam.TabStop = false;
        grbTeam.Text = "توضیحات";
        // 
        // ritxtTeamDescription
        // 
        ritxtTeamDescription.Dock = DockStyle.Fill;
        ritxtTeamDescription.Location = new Point(3, 19);
        ritxtTeamDescription.Name = "ritxtTeamDescription";
        ritxtTeamDescription.Size = new Size(494, 35);
        ritxtTeamDescription.TabIndex = 0;
        ritxtTeamDescription.Text = "";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(20, 20, 20);
        panel2.Controls.Add(btnDeleteTeam);
        panel2.Controls.Add(btnEditTeam);
        panel2.Controls.Add(btnAddTeam);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 67);
        panel2.Name = "panel2";
        panel2.Size = new Size(500, 49);
        panel2.TabIndex = 1;
        // 
        // btnDeleteTeam
        // 
        btnDeleteTeam.Dock = DockStyle.Right;
        btnDeleteTeam.FlatAppearance.BorderColor = Color.DarkGray;
        btnDeleteTeam.FlatStyle = FlatStyle.Flat;
        btnDeleteTeam.ForeColor = SystemColors.ButtonHighlight;
        btnDeleteTeam.Image = Properties.Resources.remove_user_group_man_man_24px;
        btnDeleteTeam.Location = new Point(288, 0);
        btnDeleteTeam.Name = "btnDeleteTeam";
        btnDeleteTeam.Size = new Size(65, 49);
        btnDeleteTeam.TabIndex = 2;
        btnDeleteTeam.Text = "حذف تیم";
        btnDeleteTeam.TextImageRelation = TextImageRelation.ImageAboveText;
        btnDeleteTeam.UseVisualStyleBackColor = true;
        btnDeleteTeam.Click += btnDeleteTeam_Click;
        // 
        // btnEditTeam
        // 
        btnEditTeam.Dock = DockStyle.Right;
        btnEditTeam.FlatAppearance.BorderColor = Color.DarkGray;
        btnEditTeam.FlatStyle = FlatStyle.Flat;
        btnEditTeam.ForeColor = SystemColors.ButtonHighlight;
        btnEditTeam.Image = Properties.Resources.edit_user_24px;
        btnEditTeam.Location = new Point(353, 0);
        btnEditTeam.Name = "btnEditTeam";
        btnEditTeam.Size = new Size(82, 49);
        btnEditTeam.TabIndex = 1;
        btnEditTeam.Text = "ویرایش تیم";
        btnEditTeam.TextImageRelation = TextImageRelation.ImageAboveText;
        btnEditTeam.UseVisualStyleBackColor = true;
        btnEditTeam.Click += btnEditTeam_Click;
        // 
        // btnAddTeam
        // 
        btnAddTeam.Dock = DockStyle.Right;
        btnAddTeam.FlatAppearance.BorderColor = Color.DarkGray;
        btnAddTeam.FlatStyle = FlatStyle.Flat;
        btnAddTeam.ForeColor = SystemColors.ButtonHighlight;
        btnAddTeam.Image = (Image)resources.GetObject("btnAddTeam.Image");
        btnAddTeam.Location = new Point(435, 0);
        btnAddTeam.Name = "btnAddTeam";
        btnAddTeam.Size = new Size(65, 49);
        btnAddTeam.TabIndex = 0;
        btnAddTeam.Text = "تیم جدید";
        btnAddTeam.TextImageRelation = TextImageRelation.ImageAboveText;
        btnAddTeam.UseVisualStyleBackColor = true;
        btnAddTeam.Click += btnAddTeam_Click;
        // 
        // dgvPlayers
        // 
        dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPlayers.Dock = DockStyle.Fill;
        dgvPlayers.Location = new Point(0, 0);
        dgvPlayers.MultiSelect = false;
        dgvPlayers.Name = "dgvPlayers";
        dgvPlayers.RowTemplate.Height = 25;
        dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPlayers.Size = new Size(455, 362);
        dgvPlayers.TabIndex = 5;
        dgvPlayers.SelectionChanged += dgvPlayers_SelectionChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(ritxtPlayerDescription);
        groupBox1.Dock = DockStyle.Bottom;
        groupBox1.ForeColor = SystemColors.ButtonHighlight;
        groupBox1.Location = new Point(0, 362);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(455, 57);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "توضیحات";
        // 
        // ritxtPlayerDescription
        // 
        ritxtPlayerDescription.Dock = DockStyle.Fill;
        ritxtPlayerDescription.Location = new Point(3, 19);
        ritxtPlayerDescription.Name = "ritxtPlayerDescription";
        ritxtPlayerDescription.Size = new Size(449, 35);
        ritxtPlayerDescription.TabIndex = 0;
        ritxtPlayerDescription.Text = "";
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(20, 20, 20);
        panel3.Controls.Add(button3);
        panel3.Controls.Add(btnEditPlayer);
        panel3.Controls.Add(btnNewPlayer);
        panel3.Dock = DockStyle.Bottom;
        panel3.Location = new Point(0, 419);
        panel3.Name = "panel3";
        panel3.Size = new Size(455, 49);
        panel3.TabIndex = 0;
        // 
        // button3
        // 
        button3.Dock = DockStyle.Right;
        button3.FlatAppearance.BorderColor = Color.DarkGray;
        button3.FlatStyle = FlatStyle.Flat;
        button3.ForeColor = SystemColors.ButtonHighlight;
        button3.Image = (Image)resources.GetObject("button3.Image");
        button3.Location = new Point(191, 0);
        button3.Name = "button3";
        button3.Size = new Size(92, 49);
        button3.TabIndex = 3;
        button3.Text = "حذف بازیکن";
        button3.TextImageRelation = TextImageRelation.ImageAboveText;
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // btnEditPlayer
        // 
        btnEditPlayer.Dock = DockStyle.Right;
        btnEditPlayer.FlatAppearance.BorderColor = Color.DarkGray;
        btnEditPlayer.FlatStyle = FlatStyle.Flat;
        btnEditPlayer.ForeColor = SystemColors.ButtonHighlight;
        btnEditPlayer.Image = (Image)resources.GetObject("btnEditPlayer.Image");
        btnEditPlayer.Location = new Point(283, 0);
        btnEditPlayer.Name = "btnEditPlayer";
        btnEditPlayer.Size = new Size(89, 49);
        btnEditPlayer.TabIndex = 2;
        btnEditPlayer.Text = "ویرایش بازیکن";
        btnEditPlayer.TextImageRelation = TextImageRelation.ImageAboveText;
        btnEditPlayer.UseVisualStyleBackColor = true;
        btnEditPlayer.Click += btnEditPlayer_Click;
        // 
        // btnNewPlayer
        // 
        btnNewPlayer.Dock = DockStyle.Right;
        btnNewPlayer.FlatAppearance.BorderColor = Color.DarkGray;
        btnNewPlayer.FlatStyle = FlatStyle.Flat;
        btnNewPlayer.ForeColor = SystemColors.ButtonHighlight;
        btnNewPlayer.Image = (Image)resources.GetObject("btnNewPlayer.Image");
        btnNewPlayer.Location = new Point(372, 0);
        btnNewPlayer.Name = "btnNewPlayer";
        btnNewPlayer.Size = new Size(83, 49);
        btnNewPlayer.TabIndex = 1;
        btnNewPlayer.Text = "بازیکن جدید";
        btnNewPlayer.TextImageRelation = TextImageRelation.ImageAboveText;
        btnNewPlayer.UseVisualStyleBackColor = true;
        btnNewPlayer.Click += btnNewPlayer_Click;
        // 
        // MainFrom
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(959, 521);
        Controls.Add(pnlFormLoader);
        Controls.Add(topPanel);
        DoubleBuffered = true;
        Name = "MainFrom";
        RightToLeft = RightToLeft.Yes;
        Text = "پنل مدیریت تیم";
        Load += MainFrom_Load;
        topPanel.ResumeLayout(false);
        topPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        pnlFormLoader.ResumeLayout(false);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTeam).EndInit();
        panel1.ResumeLayout(false);
        grbTeam.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
        groupBox1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ResumeLayout(false);
    }



    #endregion

    private Panel topPanel;
    private Panel pnlFormLoader;
    private PictureBox pictureBox1;
    private Label label1;
    private SplitContainer splitContainer1;
    private DataGridView dgvTeam;
    private Panel panel1;
    private GroupBox grbTeam;
    private Panel panel2;
    private RichTextBox ritxtTeamDescription;
    private Button btnAddTeam;
    private Button btnDeleteTeam;
    private Button btnEditTeam;
    private Panel panel3;
    private Label label2;
    private GroupBox groupBox1;
    private RichTextBox ritxtPlayerDescription;
    private DataGridView dgvPlayers;
    private Button button3;
    private Button btnEditPlayer;
    private Button btnNewPlayer;
}
