
namespace StarterDashbord.Forms;

partial class AddPlayerForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        panel1 = new Panel();
        btnSave = new Button();
        panel2 = new Panel();
        txtDescription = new TextBox();
        label8 = new Label();
        mtxtEndDate = new MaskedTextBox();
        label7 = new Label();
        mtxtStartDate = new MaskedTextBox();
        label6 = new Label();
        cmbTeamName = new ComboBox();
        label5 = new Label();
        mtxtSocialCode = new MaskedTextBox();
        label4 = new Label();
        mtxtBirth = new MaskedTextBox();
        label3 = new Label();
        txtLastName = new TextBox();
        label2 = new Label();
        txtName = new TextBox();
        label1 = new Label();
        errorProvider = new ErrorProvider(components);
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(20, 20, 20);
        panel1.Controls.Add(btnSave);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 110);
        panel1.Name = "panel1";
        panel1.Size = new Size(641, 46);
        panel1.TabIndex = 0;
        // 
        // btnSave
        // 
        btnSave.Dock = DockStyle.Left;
        btnSave.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.ForeColor = SystemColors.ButtonHighlight;
        btnSave.Image = Properties.Resources.save_24px;
        btnSave.Location = new Point(0, 0);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(75, 46);
        btnSave.TabIndex = 1;
        btnSave.Text = "ذخیره";
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(40, 40, 40);
        panel2.Controls.Add(txtDescription);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(mtxtEndDate);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(mtxtStartDate);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(cmbTeamName);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(mtxtSocialCode);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(mtxtBirth);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(txtLastName);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(txtName);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Fill;
        panel2.ForeColor = SystemColors.ButtonHighlight;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(641, 110);
        panel2.TabIndex = 1;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(3, 67);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(355, 23);
        txtDescription.TabIndex = 15;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(360, 72);
        label8.Name = "label8";
        label8.Size = new Size(57, 15);
        label8.TabIndex = 14;
        label8.Text = "توضیحات:";
        // 
        // mtxtEndDate
        // 
        mtxtEndDate.Location = new Point(438, 64);
        mtxtEndDate.Mask = "0000/00/00";
        mtxtEndDate.Name = "mtxtEndDate";
        mtxtEndDate.Size = new Size(92, 23);
        mtxtEndDate.TabIndex = 13;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(536, 67);
        label7.Name = "label7";
        label7.Size = new Size(94, 15);
        label7.TabIndex = 12;
        label7.Text = "تاریخ پایان قرارداد:";
        // 
        // mtxtStartDate
        // 
        mtxtStartDate.Location = new Point(3, 38);
        mtxtStartDate.Mask = "0000/00/00";
        mtxtStartDate.Name = "mtxtStartDate";
        mtxtStartDate.Size = new Size(92, 23);
        mtxtStartDate.TabIndex = 11;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(101, 38);
        label6.Name = "label6";
        label6.Size = new Size(98, 15);
        label6.TabIndex = 10;
        label6.Text = "تاریخ شروع قرارداد:";
        label6.Click += label6_Click;
        // 
        // cmbTeamName
        // 
        cmbTeamName.FormattingEnabled = true;
        cmbTeamName.Location = new Point(200, 35);
        cmbTeamName.Name = "cmbTeamName";
        cmbTeamName.Size = new Size(158, 23);
        cmbTeamName.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(360, 38);
        label5.Name = "label5";
        label5.Size = new Size(42, 15);
        label5.TabIndex = 8;
        label5.Text = "نام تیم:";
        label5.Click += label5_Click;
        // 
        // mtxtSocialCode
        // 
        mtxtSocialCode.Location = new Point(438, 35);
        mtxtSocialCode.Mask = "0000000000";
        mtxtSocialCode.Name = "mtxtSocialCode";
        mtxtSocialCode.Size = new Size(142, 23);
        mtxtSocialCode.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(582, 38);
        label4.Name = "label4";
        label4.Size = new Size(43, 15);
        label4.TabIndex = 6;
        label4.Text = "کدملی:";
        // 
        // mtxtBirth
        // 
        mtxtBirth.Location = new Point(3, 6);
        mtxtBirth.Mask = "0000/00/00";
        mtxtBirth.Name = "mtxtBirth";
        mtxtBirth.Size = new Size(91, 23);
        mtxtBirth.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(101, 9);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 4;
        label3.Text = "تاریخ تولد:";
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(201, 6);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(158, 23);
        txtLastName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(360, 9);
        label2.Name = "label2";
        label2.Size = new Size(72, 15);
        label2.TabIndex = 2;
        label2.Text = "نام خانوادگی:";
        label2.Click += label2_Click;
        // 
        // txtName
        // 
        txtName.Location = new Point(438, 6);
        txtName.Name = "txtName";
        txtName.Size = new Size(142, 23);
        txtName.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(586, 9);
        label1.Name = "label1";
        label1.Size = new Size(27, 15);
        label1.TabIndex = 0;
        label1.Text = "نام :";
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // AddPlayerForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(641, 156);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "AddPlayerForm";
        RightToLeft = RightToLeft.Yes;
        Text = "AddPlayerForm";
        Load += AddPlayerForm_Load;
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
    }

    private void label6_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label1;
    private Label label2;
    private TextBox txtName;
    private TextBox txtLastName;
    private Label label3;
    private MaskedTextBox mtxtBirth;
    private MaskedTextBox mtxtSocialCode;
    private Label label4;
    private Label label5;
    private MaskedTextBox mtxtStartDate;
    private Label label6;
    private ComboBox cmbTeamName;
    private MaskedTextBox mtxtEndDate;
    private Label label7;
    private Label label8;
    private TextBox txtDescription;
    private Button btnSave;
    private ErrorProvider errorProvider;
}