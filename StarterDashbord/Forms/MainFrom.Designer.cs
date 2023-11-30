
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
        label1 = new Label();
        pictureBox1 = new PictureBox();
        pnlFormLoader = new Panel();
        splitContainer1 = new SplitContainer();
        panel1 = new Panel();
        grbTeam = new GroupBox();
        ritxtTeamDescription = new RichTextBox();
        panel2 = new Panel();
        dgvTeam = new DataGridView();
        btnAddTeam = new Button();
        button1 = new Button();
        button2 = new Button();
        topPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        pnlFormLoader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.SuspendLayout();
        panel1.SuspendLayout();
        grbTeam.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTeam).BeginInit();
        SuspendLayout();
        // 
        // topPanel
        // 
        topPanel.BackColor = Color.FromArgb(20, 20, 20);
        topPanel.Controls.Add(label1);
        topPanel.Controls.Add(pictureBox1);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(959, 81);
        topPanel.TabIndex = 0;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.Location = new Point(780, 29);
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
        pictureBox1.Size = new Size(65, 81);
        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // pnlFormLoader
        // 
        pnlFormLoader.BackColor = Color.FromArgb(40, 40, 40);
        pnlFormLoader.Controls.Add(splitContainer1);
        pnlFormLoader.Dock = DockStyle.Fill;
        pnlFormLoader.Location = new Point(0, 81);
        pnlFormLoader.Name = "pnlFormLoader";
        pnlFormLoader.Size = new Size(959, 440);
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
        splitContainer1.Panel1.Controls.Add(panel1);
        splitContainer1.Panel1.Controls.Add(dgvTeam);
        splitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.RightToLeft = RightToLeft.Yes;
        splitContainer1.Size = new Size(959, 440);
        splitContainer1.SplitterDistance = 319;
        splitContainer1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(grbTeam);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 324);
        panel1.Name = "panel1";
        panel1.Size = new Size(319, 116);
        panel1.TabIndex = 5;
        // 
        // grbTeam
        // 
        grbTeam.Controls.Add(ritxtTeamDescription);
        grbTeam.Dock = DockStyle.Bottom;
        grbTeam.ForeColor = SystemColors.ButtonHighlight;
        grbTeam.Location = new Point(0, 10);
        grbTeam.Name = "grbTeam";
        grbTeam.Size = new Size(319, 57);
        grbTeam.TabIndex = 0;
        grbTeam.TabStop = false;
        grbTeam.Text = "توضیحات";
        // 
        // ritxtTeamDescription
        // 
        ritxtTeamDescription.Dock = DockStyle.Fill;
        ritxtTeamDescription.Location = new Point(3, 19);
        ritxtTeamDescription.Name = "ritxtTeamDescription";
        ritxtTeamDescription.Size = new Size(313, 35);
        ritxtTeamDescription.TabIndex = 0;
        ritxtTeamDescription.Text = "";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(20, 20, 20);
        panel2.Controls.Add(button2);
        panel2.Controls.Add(button1);
        panel2.Controls.Add(btnAddTeam);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 67);
        panel2.Name = "panel2";
        panel2.Size = new Size(319, 49);
        panel2.TabIndex = 1;
        // 
        // dgvTeam
        // 
        dgvTeam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTeam.Dock = DockStyle.Fill;
        dgvTeam.Location = new Point(0, 0);
        dgvTeam.Name = "dgvTeam";
        dgvTeam.RowTemplate.Height = 25;
        dgvTeam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTeam.Size = new Size(319, 440);
        dgvTeam.TabIndex = 4;
        dgvTeam.SelectionChanged += dgvTeam_SelectionChanged;
        // 
        // btnAddTeam
        // 
        btnAddTeam.Dock = DockStyle.Right;
        btnAddTeam.FlatAppearance.BorderColor = Color.DarkGray;
        btnAddTeam.FlatStyle = FlatStyle.Flat;
        btnAddTeam.ForeColor = SystemColors.ButtonHighlight;
        btnAddTeam.Image = (Image)resources.GetObject("btnAddTeam.Image");
        btnAddTeam.Location = new Point(254, 0);
        btnAddTeam.Name = "btnAddTeam";
        btnAddTeam.Size = new Size(65, 49);
        btnAddTeam.TabIndex = 0;
        btnAddTeam.Text = "تیم جدید";
        btnAddTeam.TextImageRelation = TextImageRelation.ImageAboveText;
        btnAddTeam.UseVisualStyleBackColor = true;
        btnAddTeam.Click += btnAddTeam_Click;
        // 
        // button1
        // 
        button1.Dock = DockStyle.Right;
        button1.FlatAppearance.BorderColor = Color.DarkGray;
        button1.FlatStyle = FlatStyle.Flat;
        button1.ForeColor = SystemColors.ButtonHighlight;
        button1.Image = Properties.Resources.edit_user_24px;
        button1.Location = new Point(172, 0);
        button1.Name = "button1";
        button1.Size = new Size(82, 49);
        button1.TabIndex = 1;
        button1.Text = "ویرایش تیم";
        button1.TextImageRelation = TextImageRelation.ImageAboveText;
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Dock = DockStyle.Right;
        button2.FlatAppearance.BorderColor = Color.DarkGray;
        button2.FlatStyle = FlatStyle.Flat;
        button2.ForeColor = SystemColors.ButtonHighlight;
        button2.Image = Properties.Resources.remove_user_group_man_man_24px;
        button2.Location = new Point(107, 0);
        button2.Name = "button2";
        button2.Size = new Size(65, 49);
        button2.TabIndex = 2;
        button2.Text = "حذف تیم";
        button2.TextImageRelation = TextImageRelation.ImageAboveText;
        button2.UseVisualStyleBackColor = true;
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
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        grbTeam.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTeam).EndInit();
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
    private Button button2;
    private Button button1;
}
