namespace StarterDashbord.Forms;

partial class AddTeamForm
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
        label7 = new Label();
        ritxtDescription = new RichTextBox();
        cmbSecondColor = new ComboBox();
        label6 = new Label();
        cmbFirstColor = new ComboBox();
        label5 = new Label();
        cmbGrade = new ComboBox();
        label4 = new Label();
        label3 = new Label();
        cmbTeamType = new ComboBox();
        label2 = new Label();
        mtxtCreateDate = new MaskedTextBox();
        label1 = new Label();
        txtTeamName = new TextBox();
        panel2 = new Panel();
        btnSave = new Button();
        errorProvider = new ErrorProvider(components);
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(40, 40, 40);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(ritxtDescription);
        panel1.Controls.Add(cmbSecondColor);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(cmbFirstColor);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(cmbGrade);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(cmbTeamType);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(mtxtCreateDate);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(txtTeamName);
        panel1.Dock = DockStyle.Fill;
        panel1.ForeColor = SystemColors.ButtonHighlight;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(514, 223);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(417, 110);
        label7.Name = "label7";
        label7.Size = new Size(57, 15);
        label7.TabIndex = 13;
        label7.Text = "توضیحات:";
        // 
        // ritxtDescription
        // 
        ritxtDescription.Location = new Point(4, 110);
        ritxtDescription.Name = "ritxtDescription";
        ritxtDescription.Size = new Size(412, 54);
        ritxtDescription.TabIndex = 12;
        ritxtDescription.Text = "";
        // 
        // cmbSecondColor
        // 
        cmbSecondColor.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSecondColor.FormattingEnabled = true;
        cmbSecondColor.Location = new Point(4, 81);
        cmbSecondColor.Name = "cmbSecondColor";
        cmbSecondColor.Size = new Size(159, 23);
        cmbSecondColor.TabIndex = 11;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(164, 84);
        label6.Name = "label6";
        label6.Size = new Size(79, 15);
        label6.TabIndex = 10;
        label6.Text = "رنگ لباس دوم:";
        // 
        // cmbFirstColor
        // 
        cmbFirstColor.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFirstColor.FormattingEnabled = true;
        cmbFirstColor.Location = new Point(257, 78);
        cmbFirstColor.Name = "cmbFirstColor";
        cmbFirstColor.Size = new Size(159, 23);
        cmbFirstColor.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(417, 81);
        label5.Name = "label5";
        label5.Size = new Size(89, 15);
        label5.TabIndex = 8;
        label5.Text = "رنگ لباس اصلی:";
        label5.Click += label5_Click;
        // 
        // cmbGrade
        // 
        cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbGrade.FormattingEnabled = true;
        cmbGrade.Location = new Point(4, 45);
        cmbGrade.Name = "cmbGrade";
        cmbGrade.Size = new Size(159, 23);
        cmbGrade.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(164, 48);
        label4.Name = "label4";
        label4.Size = new Size(26, 15);
        label4.TabIndex = 6;
        label4.Text = "رده:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(417, 45);
        label3.Name = "label3";
        label3.Size = new Size(45, 15);
        label3.TabIndex = 5;
        label3.Text = "نوع تیم:";
        // 
        // cmbTeamType
        // 
        cmbTeamType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTeamType.FormattingEnabled = true;
        cmbTeamType.Location = new Point(257, 42);
        cmbTeamType.Name = "cmbTeamType";
        cmbTeamType.Size = new Size(159, 23);
        cmbTeamType.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(164, 12);
        label2.Name = "label2";
        label2.Size = new Size(72, 15);
        label2.TabIndex = 3;
        label2.Text = "تاریخ تاسیس:";
        label2.Click += label2_Click;
        // 
        // mtxtCreateDate
        // 
        mtxtCreateDate.Location = new Point(97, 9);
        mtxtCreateDate.Mask = "0000/00/00";
        mtxtCreateDate.Name = "mtxtCreateDate";
        mtxtCreateDate.Size = new Size(66, 23);
        mtxtCreateDate.TabIndex = 2;
        mtxtCreateDate.TypeValidationCompleted += maskedTextBox1_TypeValidationCompleted;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(417, 12);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 1;
        label1.Text = "نام تیم:";
        // 
        // txtTeamName
        // 
        txtTeamName.Location = new Point(257, 9);
        txtTeamName.Name = "txtTeamName";
        txtTeamName.Size = new Size(159, 23);
        txtTeamName.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(20, 20, 20);
        panel2.Controls.Add(btnSave);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 170);
        panel2.Name = "panel2";
        panel2.Size = new Size(514, 53);
        panel2.TabIndex = 1;
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
        btnSave.Size = new Size(75, 53);
        btnSave.TabIndex = 0;
        btnSave.Text = "ذخیره";
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // AddTeamForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(514, 223);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "AddTeamForm";
        RightToLeft = RightToLeft.Yes;
        Text = "تیم جدید";
        Load += AddTeamForm_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private TextBox txtTeamName;
    private Label label1;
    private MaskedTextBox mtxtCreateDate;
    private ErrorProvider errorProvider;
    private Label label2;
    private Label label3;
    private ComboBox cmbTeamType;
    private Label label4;
    private Label label5;
    private ComboBox cmbGrade;
    private ComboBox cmbSecondColor;
    private Label label6;
    private ComboBox cmbFirstColor;
    private Label label7;
    private RichTextBox ritxtDescription;
    private Button btnSave;
}